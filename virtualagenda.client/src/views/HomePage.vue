<script setup>
    import ContentWrapper from "../components/ContentWrapper.vue";
</script>

<template>
        <ContentWrapper>
            <div>
                <img class="float-start" src="../assets/agenda-undraw.svg" alt="undraw-image" width="350" height="350" />
            </div>
            <div class="float-sm-end w-50">
                <div class="mt-5">
                    <h1 class="mb-4">Welcome :)</h1>
                    <p class="mt-4 text-break">
                        This is your VirtualAgenda, an application developed in
                        .NET 8.0 and Vue.js that allows you to have organization
                        in the palm of your hands.
                    </p>

                    <div v-if="loading" class="loading">
                        Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationvue">https://aka.ms/jspsintegrationvue</a> for more details.
                    </div>

                    <div>
                        <p class="mb-4">Start by adding a new item to it!</p>
                        <div>
                            <RouterLink to="/add"><a class="btn btn-outline-none py-2 px-5 text-white font-semibold rounded-pill shadow-lg my-btn">Let's start!</a></RouterLink>
                        </div>
                    </div>
                </div>
            </div>
        </ContentWrapper>
</template>

<script>
    export default {
        name: 'HomePage'
    };
</script>

<style scoped>
    .my-btn {
        background-color: #fa5378;
    }
</style>
