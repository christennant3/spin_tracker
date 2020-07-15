<template>
  <div class="home">
    <div class="contenttext">
      <h1>Meniere’s Symptoms - Identify your triggers</h1>
      <!-- <div v-for="weather in weathers" v-bind:key="weather.id">
        <Card dis-hover>Pollen: {{ weather.pollen }}</Card>
      </div> -->
    </div>
    <div class="contentimage">
     <img src="../../images/balance.jpg" alt="stones balancing" />
    </div>

  </div>
</template>
<style scoped>
.home {
  display: grid;
  grid-template-areas: "contenttext contenttext";
}

.contenttext {
  grid-area: contenttext;

}

.contentimage {
  grid-area: contentimage;

}


</style>

<script lang="ts">
import Vue from "vue";
import axios from "axios";
import { HTTP } from "../../js/http-common";
export default Vue.extend({
  data: function() {
    return {
      weathers: []
    };
  },
  filters: {},
  mounted() {
    const axios = require("axios");

 /*    HTTP.get("Weather/GetAll").then(response => {
      this.weathers = response.data.result.items;
    }); */

    if (process.env.NODE_ENV === "development") {
      console.log("DEV");
    } else if (process.env.NODE_ENV === "production") {
      console.log("PRODUCTION");
    } else {
      console.log("OTHER");
    }
  },

  methods: {},

  computed: {}
});
</script>

