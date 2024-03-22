
<template>
    <ContentWrapper>
        <div class="float-sm-start w-50">
            <div class="ms-4 ps-4 w-50 my-table">
                <h1 class="fs-2 pb-4">My Agenda</h1>

                <table class="table table-transparent ">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Phone Number</th>
                        </tr>
                    </thead>
                </table>
                <div>
                    <p>Aqui apareceriam os dados adicionados</p>
                </div>
            </div>
        </div>
        <div class="img-container">
            <img src="../assets/diary-undraw.svg" width="500" height="500" />
        </div>
    </ContentWrapper>
  
</template>

<script>
    export default {
        name: 'ListPage'
    }
</script>

<style scoped>
    .my-table {
        transform:translateY(100%);
    }
    .img-container {
        margin-left:60%;
        transform: translateY(25%);
    }
</style>