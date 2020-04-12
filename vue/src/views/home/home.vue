<template>
  <div>
    <h1>Home Page</h1>
    <Card dis-hover>Card</Card>
  </div>
</template>
<script lang="ts">
import Vue from "vue";
export default Vue.extend({
  data: {
      weathers: []
  },
  filters: {},
  mounted() {


      axios.get("/api/results").then(response => {
      this.weathers = response.data;
    })
  },

  methods: {},

  computed: {}
});
</script>

