<template>
 <div class="modal fade" id="NewBugModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Create Bug</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        <div class="mb-3">
          <input type="text" name="" id="" class="form-control" placeholder="Name" aria-describedby="helpId">
          <!-- <small id="helpId" class="text-muted">Help text</small> -->
          <input type="text" name="" id="" class="form-control" placeholder="Project" aria-describedby="helpId">
          <small id="helpId" class="text-muted">Select project this bug belongs to</small>
          
        </div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary" @click="createBug()" title="Create Modal">Save changes</button>
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
        async createBug(){
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