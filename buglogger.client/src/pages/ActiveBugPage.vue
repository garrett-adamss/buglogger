<template>
 <div>
    Active bug page
    {{ bug.name }}
</div>
</template>
 
<script>
import { computed } from '@vue/runtime-core'
import { AppState } from '../AppState'
export default {
   setup(){
      return {
        bug: computed(() => AppState.activeBug)

        
      }
   }
}
</script>
 
<style> 
</style>