import Vue from 'vue'
import Vuex from 'vuex'

import Counter from './modules/Counter'
import Stocks from './modules/Stocks'

Vue.use(Vuex)

const debug = process.env.NODE_ENV !== 'production'

export default new Vuex.Store({
  modules: {
    Counter,
    Stocks
  },
  strict: debug
})