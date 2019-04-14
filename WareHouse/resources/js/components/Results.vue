<template>
  <div>
            <form class="col s12" autocomplete="off"  v-on:submit.prevent="saveAmount" method="post">

                <div class="row">
                  <h3 class="col s12 m12 l12">Затраты</h3>
                  <div class=" col s12 m12 l12"><p>Всего за период расход: {{cTotalAmount}}</p></div>
                  <div class=" col s12 m12 l12"><p>Всего за период доход: {{cTotalProfit}}</p></div>
                  <div class=" col s12 m12 l12"><p>Остаток : {{cTotalProfit - cTotalAmount}}</p></div>
                </div>

                  <div  class="row">
                      <div class="input-field col s12 m12 l6">
                      <input date class="datepicker date_start" type="text"  v-model="dateStart">
                      <label class="active" for="dateStart">От</label>
                      </div>

                      <div class="input-field col s12 m12 l6">
                      <input date class="datepicker  date_end" type="text"  v-model="dateEnd">
                      <label class="active" for="dateEnd">До</label>
                      </div>
                  </div>

                <div  class="row">
                  <div v-for="field in cFields" class="input-field col s12 m12 l6">
                    <input v-if="field.is_profit == 0" type="text" v-model="field.amount">
                    <input v-else="" type="text" v-model="field.profit">
                    <label class="active" for="name">{{field.type}}</label>
                  </div>
                </div>

                <button class="btn waves-effect waves-light" type="submit" name="action">Выбрать период
                <i class="material-icons right">send</i>
                </button>


              </form>
          <preloader v-if="isLoad" ></preloader>
        </div>
</template>

<script>
import Preloader from './parts/Preloader.vue';

export default {
    components : {
        preloader : Preloader
    },
    methods : {
        getResults : function() {


                this.axios.post('/api/result',{
                            dateStart : this.dateStart,
                            dateEnd : this.dateEnd,
                        }).then((response) => {
                                      this.fields = response.data.fields
                                      this.isLoad = false;
                        })


        }
    },
  data: function () {
    return {
                fields: [],
                isLoad : true,
                dateStart : new Date(new Date().getFullYear(), new Date().getMonth(), 1).toLocaleDateString(),
                dateEnd : new Date(new Date().getFullYear(), new Date().getMonth() + 1, 0).toLocaleDateString(),

            }
  },
  mounted () {
    this.getResults();
    var app = this;
    var elems = document.querySelectorAll('.datepicker');
            var instances = M.Datepicker.init(elems,{
                format : "dd.mm.yyyy",
                onClose : function (vv) {
                    app.getResults();
                },
                onSelect : function (value) {
                    if(this.el.classList.contains('date_start')) {
                        app.dateStart = value.toLocaleDateString();
                    }
                    if(this.el.classList.contains('date_end')) {
                        app.dateEnd = value.toLocaleDateString();
                    }
                },

            });
  },
   computed : {
       cFields : function() {
           return this.fields;
       },
       cTotalAmount : function() {
           var result = 0;
           this.fields.forEach(function(item) {
               if(item.amount) {
                   result += parseInt(item.amount);
               }

           });
           return result;
       },
        cTotalProfit : function() {
           var result = 0;
           this.fields.forEach(function(item) {
               if(item.profit && item.is_profit == 1) {
                   result += parseInt(item.profit);
               }

           });
           return result;
       }
   }
}
</script>

<style scoped>

</style>