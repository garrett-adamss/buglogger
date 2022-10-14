<template>
     <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasRight" aria-labelledby="offcanvasRightLabel">
      <div class="offcanvas-header">
        <h5 class="offcanvas-title" id="offcanvasBottomLabel">Hello, {{user.name}}</h5>
        <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
      </div>
      <div class="offcanvas-body small">
        <router-link :to="{name: 'Account'}">
          <div class="list-group-item list-group-item-action hoverable" title="My Account" name="My Account">
            My Account
          </div>
        </router-link>
        <div
          class="list-group-item list-group-item-action hoverable text-danger"
          @click="logout"
          title="Logout" name="Logout"
        >
          <i class="mdi mdi-logout"></i>
          logout
        </div>
          
      </div>
    </div>
</template>
 
<script>
import { computed } from '@vue/runtime-core';
import { AuthService } from '../services/AuthService';
import { AppState } from '../AppState';

export default {
   setup(){
      return {
        user: computed(() => AppState.user),
        account: computed(()=> AppState.account),
        async logout() {
        AuthService.logout({ returnTo: window.location.origin });
      },
      }
   }
}
</script>
 
<style> 
.offcanvas{
    --bs-offcanvas-width: 310px!important;
}
.hoverable {
  cursor: pointer;
}
</style>