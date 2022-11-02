<template>
  <nav class="navbar navbar-expand-lg px-3">
    <router-link class="navbar-brand d-flex" :to="{ name: 'Home' }">
      <div class="d-flex flex-column align-items-center">
        <img alt="logo" src="https://logoeps.com/wp-content/uploads/2014/04/3886-b-logo-square-icon-vector-icon-vector-eps.png" height="45" />
      </div>
    </router-link>
    <button
      class="navbar-toggler"
      type="button"
      data-bs-toggle="collapse"
      data-bs-target="#navbarText"
      aria-controls="navbarText"
      aria-expanded="false"
      aria-label="Toggle navigation"
    >
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarText">
      <ul class="navbar-nav me-auto">
        <router-link :to="{ name: 'BugPage' }">
          <li class="p-3">
           Bugs
          </li>
        </router-link>
        <router-link :to="{ name: 'ProjectsPage' }">
          <li class="p-3">
           Projects
          </li>
        </router-link>
      </ul>
      <!-- LOGIN COMPONENT HERE -->
      <Login />
    </div>
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
