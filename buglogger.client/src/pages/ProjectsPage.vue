<template>
  <div class="d-flex row align-items-center project-title">
    <div class="col-1 ms-3"><p class="project-subtitle user-select-none">User</p></div>
    <div class="col-2 offset-1"><p class="project-subtitle">Project</p></div>
    <div class="col-2"><p class="project-subtitle">Bug Count</p></div>
    <div class="col-4"><p class="project-subtitle user-select-none">Description</p></div>
    <div class="col-1"><p class="project-subtitle user-select-none">Status</p></div>
  </div>
  <div class="top-line mb-1">
  </div>
  <div v-for="p in projects" :key="p.id">
      <Project :project="p"/>
    </div>
</template>
 `1`
<script>
import { computed } from '@vue/reactivity';
import { onMounted } from '@vue/runtime-core';
import Project from '../components/Project.vue';
import { projectsService } from "../services/ProjectsService"
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { AppState } from '../AppState';
export default {
    setup() {
      async function getAllProjects(){
        try {
           await projectsService.getAll()
        }
        catch (error) {
           logger.error(error)
           Pop.toast(error.message, 'error')
        }
      }
      onMounted(()=>{
        getAllProjects();
      })
        return {
          projects: computed(() => AppState.projects),
        };
    },
    components: { Project }
}
</script>
 
<style> 
.top-line{
  border-top: 2.5px solid rgb(141, 141, 141);
}
.project-subtitle{
  margin-bottom: 12px;
  margin-top: 9.5px;
  font-size: 18px;
  /* margin-left: 5px; */
  max-width: fit-content;
}
.project-title{
  margin-left: .5px;
  margin-right: 1px;
}
</style>