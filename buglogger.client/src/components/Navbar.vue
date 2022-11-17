<template>
<nav class="row nav">
  <div >
    <img alt="logo" src="https://logoeps.com/wp-content/uploads/2014/04/3886-b-logo-square-icon-vector-icon-vector-eps.png" height="45" />
  </div>
  <router-link class="navbar-brand col-8" :to="{ name: 'BugPage' }">
   <p class="selectable">Bugs</p> 
  </router-link>
  <router-link class="navbar-brand col-8" :to="{ name: 'ProjectsPage' }">
    <p class="selectable">Projects</p>
  </router-link>
  <router-link class="navbar-brand col-8" :to="{ name: 'BugPage' }">
    <p class="selectable">Bugs</p>
  </router-link>
  <Login />
</nav>

</template>

<script>
import Login from './Login.vue'
export default {
  setup() {
    return {}
  },
  components: { Login }
}
</script>

<style scoped>
a:hover {
  text-decoration: none;
}

.nav-link {
  text-transform: uppercase;
}

.navbar-nav .router-link-exact-active {
  border-bottom: 2px solid blueviolet;
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}


.nav{ 
  height: 100vh;
  border-right: 2px solid rgb(0, 0, 0);
  background-color: rgba(64, 64, 64, 0.459);
}
</style>
