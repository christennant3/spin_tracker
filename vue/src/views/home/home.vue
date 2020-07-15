<template>
  <div class="home">
    <div class="grid">
      <div class="contenttext">
  
       <h1>Meniere’s Symptoms - Identify your triggers</h1> 
        <p>Track weather, diet, stress levels, sleep etc to find out what triggers your symptoms.</p> 
        <p>An easy way to work out what cause your Vertigo, dizziness and brain fog.</p>
        <div v-for="weather in weathers" v-bind:key="weather.id">
        <Card dis-hover>Pollen: {{ weather.pollen }}</Card>
        </div>
      </div>
      <div class="contentimage">
      
       <img src="../../images/balance.jpg" alt="stones balancing" /> 
      </div>

    </div>
   
  </div>
</template>
<style scoped lang="scss">
.grid {
  display: grid;
    grid-template-columns: 1fr 1fr 1fr 1fr 1fr 1fr 1fr;

  grid-template-areas: 
  "contenttext contenttext contenttext contenttext contentimage contentimage contentimage";
  grid-gap: 50px;

  h1 {
    font-size: 2.5em;
    font-weight: normal;
    color: #20aa11;
    padding-bottom: 16px;
  }

  p {
    font-size: 1.4em;
  }
}

.contenttext {
  grid-area: contenttext;
 
}

.contentimage {
  grid-area: contentimage;
  text-align: left;

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

       HTTP.get("Weather/GetAll").then(response => {
      this.weathers = response.data.result.items;
    }); 

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

