<template>
  <span class="navbar-text">
    <button
      class="btn selectable lighten-30 text-uppercase my-2 my-lg-0"
      @click="login"
      v-if="!user.isAuthenticated"
    >
      Login
    </button>

    <div class="my-2 my-lg-0" v-else>
        <i class="settings mdi mdi-cog-outline" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasRight" aria-controls="offcanvasRight"></i>
    </div>
  </span>
</template>

<script>
import { computed } from 'vue'
import { AppState } from '../AppState'
import { AuthService } from '../services/AuthService'
import SettingsOffCanvas from './SettingsOffCanvas.vue'
export default {
    setup() {
        return {
            user: computed(() => AppState.user),
            account: computed(() => AppState.account),
            async login() {
                AuthService.loginWithPopup();
            },
            async logout() {
                AuthService.logout({ returnTo: window.location.origin });
            }
        };
    },
    components: { SettingsOffCanvas }
}
</script>

<style lang="scss" scoped>
.settings{
  font-size: 25px;
}
.dropdown-menu {
  user-select: none;
  display: block;
  transform: scale(0);
  transition: all 0.15s linear;
}

.dropdown-menu.show {
  transform: scale(1);
}

.hoverable {
  cursor: pointer;
}
</style>
