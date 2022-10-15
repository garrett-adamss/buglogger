<template>
  <div class="top-line">
  </div>
  <div class="d-flex row align-items-center title">
    <div class="col-1 ms-3"><p class="subtitle user-select-none">Priority</p></div>
    <div class="col-2 offset-1 selectable"><p class="subtitle ">Project</p></div>
    <div class="col-2 selectable"><p class="subtitle">Bug</p></div>
    <div class="col-4"><p class="subtitle user-select-none">Description</p></div>
    <div class="col-1"><p class="subtitle user-select-none">Status</p></div>
  </div>
  <Bug/>

</template>

<script>
import Bug from '../components/Bug.vue';
export default {
    setup() {
        return {};
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
