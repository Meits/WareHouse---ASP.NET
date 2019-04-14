<template>
  <div>
          <div class="alert alert-danger" v-if="error && !success">
              <p>Ошибка входа</p>
          </div>
          <div class="container register_wrap">
              <form class="col s12" autocomplete="off"  v-on:submit.prevent="login" method="post">

              <div class="row">
                <h3 class="col s12 m12 l12">Аутентификация</h3>
              </div>

        <div class="row">
                <div class="input-field col s12">
                  <input id="email" v-model="email" type="email" class="validate">
                  <label for="email">Email</label>
                </div>
              </div>
        <div class="row">
          <div class="input-field col s12">
            <input id="password" v-model="password" type="password" class="validate">
            <label for="password">Пароль</label>
          </div>
        </div>

         <button class="btn waves-effect waves-light" type="submit" name="action">Войти
            <i class="material-icons right">send</i>
          </button>

              </form>
          </div>
    </div>
</template>

<script>
export default {
    methods :  {
        login : function () {
            var app = this
            this.$auth.login({
                data: {
                  email: app.email,
                  password: app.password
                },
                success: function () {
                },
                error: function () {},
                rememberMe: true,
                redirect: '/categories',
                fetchUser: true,
                url: 'api/Auth/Login',
                headers: { 'Content-Type': 'application/json' },
            });

        }
    },
  data: function () {
    return {
      email : '',
      password : '',
      error: false,
      success : false,
    }
  }
}
</script>

<style scoped>

</style>