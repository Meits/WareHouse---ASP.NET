<template>
    <div class="application--wrap">
        <navigation></navigation>
        <v-content>
            <div id="core-view">
              <v-fade-transition mode="out-in">
                <router-view></router-view>
              </v-fade-transition>
            </div>
        </v-content>

    </div>

</template>

<script>

    import Counter from './Counter.vue'
    import Navigation from './parts/Navigation.vue';
    
    export default {
        mounted() {
            console.log('Component mounted.')
        },
        data: () => ({

        }),
        components : {
            Counter,
            Navigation
        }
    }
    
</script>

<style lang="scss">
  #app-drawer {
    .v-list__tile {
      border-radius: 4px;

      &--buy {
        margin-top: auto;
        margin-bottom: 17px;
      }
    }

    .v-image__image--contain {
      top: 9px;
      height: 60%;
    }

    .search-input {
      margin-bottom: 30px !important;
      padding-left: 15px;
      padding-right: 15px;
    }
  }
</style>