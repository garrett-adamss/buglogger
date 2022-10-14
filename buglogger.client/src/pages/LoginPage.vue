<template>
    <div v-if="!user.isAuthenticated" class="d-flex flex-column justify-content-center align-items-center">
        <h1>Welcome to bugLogger</h1>
        <h3>Sign in or create an account to continue</h3>
        <Login/>
    </div>
    <div class="d-flex flex-column justify-content-center align-items-center" @click="toHome">
        Welcome back {{user.name}}
        <button class="btn btn-secondary">home</button>
    </div>
</template>
 
<script>
import { computed } from '@vue/runtime-core';
import Login from '../components/Login.vue';
import { AppState } from '../AppState';
import Pop from '../utils/Pop';
import { logger } from '../utils/Logger';
import { useRoute } from 'vue-router';
export default {
    setup() {
        const router = useRoute();
        return {
            user: computed(() => AppState.user),
            async toHome() {
                try {
                   router.push({name: 'Home'})
                }
                catch (error) {
                   logger.error(error)
                   Pop.toast(error.message, 'error')
                }
            }
        };
    },
    components: { Login }
}
</script>
 
<style> 

</style>