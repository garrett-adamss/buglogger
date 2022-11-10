<template>
     <!-- align-items-center -->
   <div class="bug d-flex row rounded mb-1 selectable" @click="setActiveBug()">
    <div class="col-1 ms-3"><p class="bug-desc">{{ bug.priority }}</p></div>
    <div class="col-2 offset-1"><p class="bug-desc">Project</p></div>
    <div class="col-2"><p class="bug-desc">{{ bug.name }}</p></div>
    <div class="col-4"><p class="bug-desc">{{ bug.description }}</p></div>
    <div v-if="bug.following == 1 " class="col-1"><p class="bug-desc ms-4"><i class="mdi mdi-check-circle"></i></p></div>
    <div v-else class="col-1"><p class="bug-desc ms-4"><i class="mdi mdi-close-outline"></i></p></div>
  </div>
  <!-- <div class="bug d-flex row rounded mb-1">
    <div class="col-1 ms-3"><p class="bug-desc">Medium</p></div>
    <div class="col-2 offset-1"><p class="bug-desc">Buglogger</p></div>
    <div class="col-2"><p class="bug-desc">account</p></div>
    <div class="col-4"><p class="bug-desc">the account profile is not working...</p></div>
    <div class="col-1"><p class="bug-desc"><i class="mdi mdi-alert-circle"></i></p></div>
  </div>
  <div class="bug d-flex row rounded mb-1">
    <div class="col-1 ms-3"><p class="bug-desc">Low</p></div>
    <div class="col-2 offset-1"><p class="bug-desc">Portfolio</p></div>
    <div class="col-2"><p class="bug-desc">user.id</p></div>
    <div class="col-4"><p class="bug-desc">cannot get porfolio pieces by user id...</p></div>
    <div class="col-1"><p class="bug-desc"><i class="mdi mdi-check-circle"></i></p></div>
  </div>
  <div class="bug d-flex row rounded mb-1">
    <div class="col-1 ms-3"><p class="bug-desc">High</p></div>
    <div class="col-2 offset-1"><p class="bug-desc">BugLogger</p></div>
    <div class="col-2"><p class="bug-desc">Database</p></div>
    <div class="col-4"><p class="bug-desc">Need too find new database since sc...</p></div>
    <div class="col-1"><p class="bug-desc"><i class="mdi mdi-alert-circle"></i></p></div>
  </div>
  <div class="bug d-flex row rounded mb-1">
    <div class="col-1 ms-3"><p class="bug-desc">Medium</p></div>
    <div class="col-2 offset-1"><p class="bug-desc">BugLogger</p></div>
    <div class="col-2"><p class="bug-desc">AWS</p></div>
    <div class="col-4"><p class="bug-desc">Figure out how to deploy a fullstack appli...</p></div>
    <div class="col-1"><p class="bug-desc"><i class="mdi mdi-alert-circle"></i></p></div>
  </div> -->
</template>
 
<script>
import { computed } from '@vue/reactivity';
import { AppState } from '../AppState'
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { bugsService } from '../services/BugsService';
export default {
  props: {
    bug: {
      type: Object,
      required: true
    },
  },
   setup(props){
      return {
        // bug: computed(() => AppState.bugs),
        async setActiveBug(){
          try {
             await bugsService.getOne(props.bug.id)
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
.bug{
    background: rgba(175, 175, 175, 0.539);
    margin-left: .5px;
    margin-right: 1px;
    border-top: 2px solid rgb(176, 176, 176);
    border-bottom: 2px solid rgb(176, 176, 176);
    border-right: 2px solid rgb(176, 176, 176);
    border-left: 2px solid rgb(176, 176, 176);
}
.bug-desc{
    margin-top: 0.75em;
    margin-bottom: 0.5em;
    max-width: fit-content;
}
.bug-start{
    margin-left: 1px;
}
</style>