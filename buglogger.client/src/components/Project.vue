<template>
     <div class="project d-flex row rounded mb-1">
    <div class="col-1 ms-3 selectable"><p class="project-desc">pfp</p></div>
    <div class="col-2 offset-1 selectable"><p class="project-desc">Keepr</p></div>
    <div class="col-2 selectable"><p class="project-desc">5</p></div>
    <div class="col-4"><p class="project-desc">pintrest style application where users...</p></div>
    <div class="col-1"><p class="project-desc"><i class="mdi mdi-check-circle selectable"></i></p></div>
  </div>
</template>
 
<script>
export default {
   setup(){
      return {
 
      }
   }
}
</script>
 
<style> 
.project{
    margin-left: .5px;
    margin-right: 1px;
    border-top: 2px solid rgb(176, 176, 176);
    border-bottom: 2px solid rgb(176, 176, 176);
    border-right: 2px solid rgb(176, 176, 176);
    border-left: 2px solid rgb(176, 176, 176);
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