import VueRouter from 'vue-router'
import Index from './components/Index.vue'
import Products from './components/Products.vue'

export default new VueRouter({
    routes: [
        {
            path: '',
            component: Index,
            name : 'home'

        },{
            path: '/products',
            component: Products,
            name : 'products'

        }
    ],
    mode: 'history'
})