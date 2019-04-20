<template>
    <v-container fill-height
                 fluid
                 grid-list-xl>
        <v-layout justify-center
                  wrap>
            <v-flex md12>
                <material-card color="green"
                               title="Stocks table"
                               text="Available stocks in database">
                    <v-data-table :headers="headers"
                                  :items="stocks"
                                  hide-actions>
                        <template slot="headerCell"
                                  slot-scope="{ header }">
                            <span class="subheading font-weight-light text-success text--darken-3"
                                  v-text="header.text" />
                        </template>
                        <template slot="items"
                                  slot-scope="{ item }">
                            <td>{{ item.id }}</td>
                            <td>{{ item.name }}</td>
                            <td>
                                <v-tooltip left color="white" >
                                  <template v-slot:activator="{ on }">
                                    <v-btn color="primary" dark @click="editHandler(item)">Edit Stock</v-btn>
                                  </template>
                                  <span >Click to edit element</span>
                                </v-tooltip>
                                <v-tooltip right color="white">
                                  <template v-slot:activator="{ on }">
                                    <v-btn color="red" dark @click="deleteHandler(item)">Delete Stock</v-btn>
                                  </template>
                                  <span>Click to delete element</span>
                                </v-tooltip>
                            </td>
                        </template>
                    </v-data-table>
                </material-card>
            </v-flex>
            <stock-modal v-bind:dialogOpen="dialog"></stock-modal>
        </v-layout>


    </v-container>

</template>

<script>
  import Card from './helpers/Card.vue';
  import StockModal from './parts/Stockmodal.vue';
      import { mapState } from 'vuex';
export default {
    components : {
        'material-card' : Card,
        'stock-modal' : StockModal,
    },

    mounted : function () {
        this.$store.dispatch('getStocks');
    },
    methods: {
        editHandler (stock) {
            this.$store.commit('setCurrentStock', stock);
            this.dialog = true;
        },

        deleteHandler(stock) {

        }
    },
    computed: {
                ...mapState({
                   stocks: state => state.Stocks.stocks
                }),
            },

  data: function () {
    return {
        dialog: false,
        headers: [
            {
                sortable: false,
                text: 'ID',
                value: 'id',
            },
            {
                sortable: false,
                text: 'Name',
                value: 'name'
            },
            {
                sortable: false,
                text: 'Actions',
                value: 'actions'
            }
        ]
    }
  }
}
</script>

<style scoped>
</style>