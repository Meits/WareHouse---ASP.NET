import VueRouter from 'vue-router'
import Index from './components/Index.vue'
import Products from './components/Products.vue'
import Stocks from './components/Stocks.vue'
import Login from './components/Login.vue'
import Register from './components/Register.vue'

export default new VueRouter({
    routes: [
        {
            path: '',
            component: Index,
            name : 'home'

        },{
            path: '/products',
            component: Products,
            name: 'products',
            meta: {

                auth: true
            }


        },{
            path: '/stocks',
            component: Stocks,
            name: 'stocks',
            meta: {

                auth: true
            }

        },
        {
            path: '/login',
            component: Login,
            name: 'login',
            meta: {

                auth: false
            }
        }, {
            path: '/register',
            component: Register,
            name: 'register',
            meta: {

                auth: false
            }
        }
    ],
    mode: 'history'
})