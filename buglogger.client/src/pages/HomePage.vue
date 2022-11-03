<template>
  <div class="container-fluid">
    <h1 class="text-center title">Welcome to bugLogger</h1>
    <div class="row justify-content-around">
      <div class="col-3 selection-box text-center rounded">
        <div class="text-box">
          <h3>Add new bug</h3>
          <i class="mdi mdi-plus" @click="createBug()"></i>
        </div>
      </div>
      <div class="col-3 selection-box text-center rounded">
        <div class="text-box">
          <h3>Add new project</h3>  
          <i class="mdi mdi-plus" @click="createProject"></i>
        </div>
      </div>
      <div class="col-3 selection-box text-center rounded">
        <div class="text-box">
          <h3>Continue to bugs</h3>
          <i class="mdi mdiArrowRight" @click="toBugPage()">>></i>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Bug from '../components/Bug.vue';
import { bugsService } from "../services/BugsService"
import { router } from '../router';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { onMounted } from '@vue/runtime-core';
export default {
    setup() {
        return {
          async toBugPage(){
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
.selection-box{
  height: 325px;
  border: 2.5px solid rgb(141, 141, 141);
}
.text-box{
  margin-top: 23%;
}
i{
  font-size: 75px;
  transition: transform 250ms;
}
.mdi:hover{
  cursor: pointer;
  transform: translateX(-5px);
}
.title{
  margin-top: 5vh;
}
.row{
  margin-top: 10vh;
}
</style>
