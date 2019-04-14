<template>
    <div>
        <div class="alert alert-danger" v-if="error && !success">
            <p>Ошибка регистрации</p>
        </div>
        <div class="container register_wrap">
            <form class="col s12" autocomplete="off"  v-on:submit.prevent="register" method="post">

            <div class="row">
              <h3 class="col s12 m12 l12">Регистрация</h3>
              <div class="alert alert-success" v-if="success">
                <p>Регистрация завершена. Вы можете войти <router-link :to="{name:'login'}">Вход</router-link></p>
              </div>
            </div>
      <div class="row">
                    <div class="input-field col s12">
                      <input id="name" v-model="name" type="text" class="validate">
                      <label for="name">Имя</label>
                    </div>
                  </div>
      <div class="row">
              <div class="input-field col s12">
                <input id="email" v-model="email" type="email" class="validate">
                <label for="email">Email (используется в качестве логина)</label>
              </div>
            </div>
      <div class="row">
        <div class="input-field col s12">
          <input id="password" v-model="password" type="password" class="validate">
          <label for="password">Пароль</label>
        </div>
      </div>

      <div class="row">
        <div class="input-field col s12">
          <input id="password_confirmation" v-model="password_confirmation" type="password" class="validate">
          <label for="password_confirmation">Подтверждение пароля</label>
        </div>
      </div>


       <button class="btn waves-effect waves-light" type="submit" name="action">Регистрация
          <i class="material-icons right">send</i>
        </button>

            </form>
        </div>
  </div>
</template>

<script>

export default{
  data: function () {
    return {
      error: false,
      success : false,
      email : '',
      password : '',
      name: '',
      password_confirmation: '',
    }
  },
  methods : {
    clearFields : function () {
        this.error = false;
        this.success = false;
        this.email = '';
        this.password = '';
        this.name = '';
        this.password_confirmation = '';
    },
    register : function () {
        var app = this
        this.$auth.register({
            data: {
                email: app.email,
                password: app.password,
                name : app.name,
                password_confirmation : app.password_confirmation
            },
            success: function () {
                app.success = true;
                M.toast({html: 'Регистрация завершена.',classes: ['teal lighten-2']});
                this.clearFields();
            },
            error: function (resp) {
                app.error = true;
                app.errors = resp.response.data.errors;
            },
            redirect: null,
            url : '/api/auth/register'
        });
    }
  }
}
</script>

<style scoped>

</style>