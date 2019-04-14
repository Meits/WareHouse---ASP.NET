import Axios from "axios";

const mutations = {
    getProducts(state, stocks) {
        state.products = products;
    }
}

const state = {
    products: []
}


const actions = {
    async getProducts(context) {
        if (state.products.length == 0) {
            await Axios.get('/api/Products').then((response) => {
                context.commit('getProducts', response.data);
            });
        }

    }
}


export default {
    namespaced: false,
    state,
    actions,
    mutations
}