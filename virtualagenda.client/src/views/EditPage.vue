<script setup>
    import ContentWrapper from "../components/ContentWrapper.vue";
</script>

<template>
    <ContentWrapper>
        <h1 class="fs-2"> Edit Informations </h1>
        <div>
            <form method="post">
                <div class="mt-2">
                    <label class="mt-3">Id</label>
                    <input type="text" class="form-control" readonly />
                </div>

                <div class="mt-1">
                    <label class="mt-3">Name</label>
                    <input type="text" class="form-control" />
                </div>

                <div class="mt-1">
                    <label class="mt-3">Email</label>
                    <input type="email" class="form-control" />
                </div>

                <div class="mt-1 mb-3">
                    <label class="mt-3">Phone Number</label>
                    <input type="text" class="form-control" />
                </div>
                <div class="row">
                    <div class="col">
                        <div>
                            <button type="submit" class="btn btn-success">Save</button>
                        </div>
                    </div>
                    <div class="col-8">
                        <div>
                            <button type="submit" class="btn btn-danger text-white">
                                Delete
                            </button>
                        </div>
                    </div>

                </div>
            </form>
        </div>
    </ContentWrapper>
</template>