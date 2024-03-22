<script setup>
    import NavBar from "./components/NavBar.vue";
    import ContentWrapper from "./components/ContentWrapper.vue";
    import RodapeVue from "./components/RodapeVue.vue"; 
</script>

<template>
    <NavBar/>
    <RouterView/>
    <RodapeVue/>
</template>

<script>
    export default {
        components: {
            NavBar,
            ContentWrapper,
            RodapeVue
        }
    }
</script>
}
