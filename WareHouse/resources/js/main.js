
import Vue from 'vue';
import Vuex from 'vuex';
import App from './components/App.vue'
import store from './store'
import Vuetify from 'vuetify'
// index.js or main.js
import 'vuetify/dist/vuetify.min.css' // Ensure you are using css-loader

import VueRouter from 'vue-router';
import router from './router';
import axios from 'axios';
import VueAxios from 'vue-axios';

Vue.use(VueRouter);
Vue.use(VueAxios, axios);
Vue.use(Vuetify);


const app = new Vue({
    el: '#app',
    store,
    router,
    render: h => h(App)
});