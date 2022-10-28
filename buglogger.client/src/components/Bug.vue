<template>
     <!-- align-items-center -->
   <div class="bug d-flex row rounded mb-1">
    <div class="col-1 ms-3 selectable"><p class="bug-desc">High</p></div>
    <div class="col-2 offset-1 selectable"><p class="bug-desc">Keepr</p></div>
    <div class="col-2 selectable"><p class="bug-desc">router-link</p></div>
    <div class="col-4"><p class="bug-desc">user router-link from the vue card to the...</p></div>
    <div class="col-1"><p class="bug-desc"><i class="mdi mdi-check-circle selectable"></i></p></div>
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
export default {
   setup(){
      return {
 
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