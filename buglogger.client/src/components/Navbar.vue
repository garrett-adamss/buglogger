<template>
<nav class="flex-column">
  <div>
    <img alt="logo" src="https://logoeps.com/wp-content/uploads/2014/04/3886-b-logo-square-icon-vector-icon-vector-eps.png" height="45" />
  </div>
  <router-link class="navbar-brand" :to="{ name: 'BugPage' }">
    Bugs
  </router-link>
  <router-link class="navbar-brand" :to="{ name: 'BugPage' }">
    Projects
  </router-link>
  <router-link class="navbar-brand" :to="{ name: 'BugPage' }">
    Bugs
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
</style>
