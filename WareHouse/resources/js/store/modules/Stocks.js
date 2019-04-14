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
        if (state.stocks.length == 0) {
            await Axios.get('/api/Stocks').then((response) => {
                context.commit('getStocks', response.data);
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