import './styles/main.css'

import { createApp } from 'vue'
import { createRouter, createWebHistory } from "vue-router";
import App from './App.vue'

import Home from "./views/HomePage.vue";
import AddPage from "./views/AddPage.vue";
import EditPage from "./views/EditPage.vue";
import ListPage from "./views/ListPage.vue";

const routes = [
    { path: "/", component: Home },
    { path: "/add", component: AddPage },
    { path: "/edit", component: EditPage },
    { path: "/agenda", component: ListPage },
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

createApp(App).use(router).mount('#app')
