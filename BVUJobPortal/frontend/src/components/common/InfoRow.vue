<template>
  <div class="flex flex-col text-sm">
    <p class="text-gray-500 font-medium">{{ label }}</p>
    <p class="text-gray-800">{{ value || "—" }}</p>
  </div>
</template>

<script setup>
defineProps({
  label: String,
  value: String
});
</script>
