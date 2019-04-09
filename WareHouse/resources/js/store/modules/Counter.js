const mutations = {
    increment(state) {
      state.count++;
    },
    decrement(state) {
      state.count--;
    }
}

const state = {
  count: 10
}

const getters =  {
    count: state => {
      return state.count;
    }
}
const actions = {
    increment(context) {
        context.commit('increment');
    },
    decrement(context) {
        context.commit('decrement');
    }
}


export default {
  namespaced: false,
  state,
  getters,
  actions,
  mutations
}