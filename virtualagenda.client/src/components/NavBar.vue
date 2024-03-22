<template>
    <section className="header fixed-top my-nav">
        <nav className="navbar navbar-expand-lg pl-0 pr-0 m-0">
            <RouterLink to="/">
                <a className="navbar-brand">
                    <img src="/agenda.png" alt="virtual-agenda-logo" class="me-2" width="50" height="50">VirtualAgenda</img>
                </a>
            </RouterLink>

            <div className="collapse navbar-collapse" id="navbarNavDropDown">
                <ul className="navbar-nav fs-5 fw-medium mx-auto">
                    <li className="nav-item">
                        <Router-link to="/">
                            <a className="nav-link" aria-current="/" href="/">
                                Home
                            </a>
                        </Router-link>

                    </li>
                    <li className="nav-item">
                        <Router-link to="/add">
                            <a className="nav-link" href="#">
                                Add item
                            </a>
                        </Router-link>

                    </li>
                    <li className="nav-item">
                        <Router-link to="/agenda">
                            <a className="nav-link" href="#">
                                My Agenda
                            </a>
                        </Router-link>

                    </li>

                </ul>
            </div>
        </nav>
    </section>
</template>

<script>
    export default {
        name: 'NavBar'
    }
</script>

<style scoped>
    .active-link {
        color: #fa5378;
    }

    .my-nav {
        padding:0;
        margin-top:-20px;
        height:100px;
        background-color: #e6e6ff;
    }
</style>


