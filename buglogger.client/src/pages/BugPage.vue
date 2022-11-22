<template>
  <div class="d-flex row align-items-center title">
    <div class="col-1 ms-3"><p class="subtitle user-select-none">Priority</p></div>
    <div class="col-2 offset-1"><p class="subtitle">Project</p></div>
    <div class="col-2"><p class="subtitle">Bug</p></div>
    <div class="col-4"><p class="subtitle user-select-none">Description</p></div>
    <div class="col-1"><p class="subtitle user-select-none">Following</p></div>
  </div>
  <div class="top-line mb-1">
  </div>
  <div v-for="b in bugs" :key="b.id">
    <Bug :bug="b"/>
  </div>
</template>
 
<script>
import Bug from '../components/Bug.vue';
import { bugsService } from "../services/BugsService"
import { router } from '../router';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { computed, onMounted } from '@vue/runtime-core';
import { AppState } from '../AppState';
export default {
    setup() {
      async function getAllBugs(){
        try {
           await bugsService.getAll()
        }
        catch (error) {
           logger.error(error)
           Pop.toast(error.message, 'error')
        }
      }
      onMounted(() =>{
        getAllBugs();
      })
        return {
          bugs: computed(() => AppState.bugs),
          async toProject(){
            try {
               router.push({name: 'ProjectsPage'})
            }
            catch (error) {
               logger.error(error)
               Pop.toast(error.message, 'error')
            }
          },
          async toBug(){
            try {
              router.push({name: 'BugPage'})
            }
            catch (error) {
               logger.error(error)
               Pop.toast(error.message, 'error')
            }
          }
        };
    },
    components: { Bug }
}
</script>

<style scoped lang="scss">
.top-line{
  border-top: 2.5px solid rgb(141, 141, 141);
}
.subtitle{
  margin-bottom: 12px;
  margin-top: 9.5px;
  font-size: 18px;
  // margin-left: 5px
  max-width: fit-content;
}
.title{
  margin-left: .5px;
  margin-right: 1px;
}
</style>