<template>
    <div>
    <h1>Count - {{ count }}</h1>
    <p @click="add">+</p>
    <p  @click="sub">-</p>
    </div>
</template>

<script>
    import { mapState } from 'vuex';
    export default {
        mounted() {
            console.log('Component Counter mounted.')
        },
        computed: {
            ...mapState({
               count: state => state.Counter.count
            }),
        }
        ,
        methods : {
            add : function () {
                this.$store.dispatch('increment');
            },
            sub : function () {
                this.$store.dispatch('decrement');
            },
        }
        
    }
</script>