import Axios from "axios";

const mutations = {
    getStocks(state, stocks) {
        state.stocks = stocks;
    }
}

const state = {
    stocks: []
}


const actions = {
    async getStocks(context) {
        await Axios.get('/api/Stocks').then((response) => {
                console.log(response.data);
                context.commit('getStocks', response.data);
        });
    }
}


export default {
    namespaced: false,
    state,
    actions,
    mutations
}