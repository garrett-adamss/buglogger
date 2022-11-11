<template>
    <div>
        Active Project Page
        {{project.name}}
    </div>
</template>
 
<script>
import { computed } from '@vue/runtime-core'
import { AppState } from '../AppState'
export default {
   setup(){
      return {
        project: computed(() => AppState.activeProject),

      }
   }
}
</script>
 
<style> 
</style>