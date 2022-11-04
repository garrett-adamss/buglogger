<template>
<div class="modal fade" id="NewProjectModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" title="Close Modal"></button>
      </div>
      <div class="modal-body">
        New Project Modal
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" title="Close Modal">Cancel</button>
        <button type="button" class="btn btn-primary" @click="createProject()" title="Create Project">Create Project</button>
      </div>
    </div>
  </div>
</div>
</template>
 
<script>
import { logger } from '../utils/Logger'
import Pop from '../utils/Pop'
export default {
   setup(){
      return {
        async createProject(){
          try {
            
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
</style>