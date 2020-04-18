<template>
  <div>
    <h1>Home Page</h1>
    <div v-for="weather in weathers" v-bind:key="weather.id">
      <Card dis-hover>Pollen: {{ weather.pollen }}</Card>
    </div>
  </div>
</template>
<script lang="ts">
import Vue from "vue";
import axios from "axios";
export default Vue.extend({
  data: function() {
    return {
      weathers: []
    };
  },
  filters: {},
  mounted() {
    const axios = require("axios");
    const api = axios.create({
      baseURL: "http://localhost:21021/api/services/app/"
    });

    api.get("Weather/GetAll").then(response => {
      this.weathers = response.data.result.items;
    });


      if (process.env.NODE_ENV === 'production') {
        console.log('production');
      }

      else {
        console.log('dev');

      }



  },

  methods: {},

  computed: {}
});
</script>

