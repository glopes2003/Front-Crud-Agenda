<script setup>
    import ContentWrapper from "../components/ContentWrapper.vue";
</script>

<template>
    <ContentWrapper>
            <div>
                <h1>Add informations </h1>

                <form method="post">
                    <div class="mt-3">
                        <label class="mt-3">Name</label>
                        <input type="text" class="form-control"/>
                    </div>

                    <div class="mt-2">
                        <label class="mt-3">Email</label>
                        <input type="email" class="form-control"/>
                    </div>

                    <div class="mt-2">
                        <label class="mt-3">Phone Number</label>
                        <input type="text" class="form-control" />
                    </div>

                    <div class="mt-3">
                        <Router-link to="/agenda" ><button type="submit" class="btn btn-outline-none py-2 px-5 text-white font-semibold rounded-pill shadow-lg my-btn">Save</button></Router-link>
                    </div>
                </form>
            </div>
    </ContentWrapper>
</template>

<script>
    export default {
        name: 'AddPage'
    };
</script>

<style scoped>
    .wrapper {
        width: 100vw;
        margin: 0 auto;
    }

    .my-btn {
        background-color: #fa5378;
    }
</style>