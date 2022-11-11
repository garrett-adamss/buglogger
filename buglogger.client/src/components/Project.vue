<template>
<router-link :to="{name:'ActiveProjectPage', params: {id:project.id}}">
    <div class="project d-flex row rounded mb-1 selectable" @click="setActiveProject">
        <div class="col-1 ms-3"><p class="project-desc">pfp</p></div>
        <div class="col-2 offset-1" @click="toProject()"><p class="project-desc">{{project.name}}</p></div>
        <div class="col-2"><p class="project-desc">5</p></div>
        <div class="col-4"><p class="project-desc">{{project.description}}</p></div>
        <div class="col-1"><p class="project-desc"><i class="mdi mdi-check-circle"></i></p></div>
    </div>
</router-link>
</template>
 
<script>
import { projectsService } from '../services/ProjectsService'
import { logger } from '../utils/Logger'
import Pop from '../utils/Pop'
export default {
    props:{ 
        project: {
            type: Object,
            required: true
        },
    },
   setup(props){
      return {
        async setActiveProject(){
            try {
               await projectsService.getOne(props.project.id);
            }
            catch (error) {
               logger.error(error)
               Pop.toast(error.message, 'error')
            }
        }
      }
   }
}
</script>
 
<style> 
.project{
    background-color: rgba(33, 153, 200, 0.416);
    margin-left: .5px;
    margin-right: 1px;
    border-top: 2px solid rgb(88, 186, 32);
    border-bottom: 2px solid rgb(33, 153, 200);
    border-right: 2px solid rgb(33, 153, 200);
    border-left: 2px solid rgb(33, 153, 200);
}
.project-desc{
    margin-top: 0.75em;
    margin-bottom: 0.5em;
    max-width: fit-content;
}
.project-start{
    margin-left: 1px;
}
</style>