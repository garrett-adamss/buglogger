<template>
  <header>
  </header>
  <main class="container-fluid">
    <div class="row">
      <div class="col-1">
        <Navbar/>
      </div>
      <div class="col-11">
        <router-view />
      </div>
      <SettingsOffCanvas/>
    </div>
  </main>
  <footer>
    <div class="text-center p-2 footer-text">
      Made by garrett-adamss 
    <a class="footer-source" href="https://github.com/garrett-adamss/portfolioLandingPage">
        &lt;source code/&gt;
    </a>
    </div>
  </footer>
</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import Navbar from './components/Navbar.vue'

export default {
  setup() {
    return {
      appState: computed(() => AppState)
    }
  },
  components: { Navbar }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";
a {
  color: black;
  text-decoration: none;
}

a:hover {
  color: black;
}
.footer-text{
  font-size: 16px;
}

footer a {
    transition: transform 250ms;
  }

  footer a:hover {
    background-color: #555;
    color: white;
    transform: translateY(-10px);
  }


</style>
