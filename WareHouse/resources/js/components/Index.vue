<template>
  <div>
    <counter></counter>
  </div>
</template>

<script>
import Counter from './Counter.vue'
export default {
  data: function () {
    return {
      greeting: 'Hello'
    }
  }
  ,
  components : {
      Counter
  }

}
</script>

<style scoped>

</style>