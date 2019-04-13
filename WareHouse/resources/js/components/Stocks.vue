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
                        </template>
                    </v-data-table>
                </material-card>
            </v-flex>
        </v-layout>
    </v-container>
</template>

<script>
  import Card from './helpers/Card.vue';
      import { mapState } from 'vuex';
export default {
    components : {
        'material-card' : Card
    },

    mounted : function () {
        this.$store.dispatch('getStocks');
    },
    methods: {

    },
    computed: {
                ...mapState({
                   stocks: state => state.Stocks.stocks
                }),
            },

  data: function () {
    return {
        headers: [
            {
                sortable: false,
                text: 'ID',
                value: 'id'
            },
            {
                sortable: false,
                text: 'Name',
                value: 'name'
            }
        ]
    }
  }
}
</script>

<style scoped>
</style>