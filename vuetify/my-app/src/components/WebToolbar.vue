<template>
    <v-toolbar class="flex-grow-0" color="green darken-4" dark>
    <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
    <router-link style="text.decoration: none; color: inherit;" to="/Home">
                <v-btn text href="WebHome.vue">Home</v-btn>
            </router-link>
            <v-btn text>Home</v-btn>
            <v-btn text>Profile</v-btn>
            <v-btn text>Unit/Lembaga</v-btn>
            <v-btn text>Akademik</v-btn>
            <v-btn text>Dokumen</v-btn>
            <v-btn text>Gallery</v-btn>
            <v-btn text>Peta</v-btn>
            <v-btn text>Video Profil</v-btn>
            <router-link style="text.decoration: none; color: inherit;" to="/Login">
                <v-btn text href="WebLogin.vue">Kontak</v-btn>
            </router-link>

        <div class="hidden-sm-and-down">
            <v-navigation-drawer
                v-model="drawer"
                absolute
                temporary
                height="800px">
            <v-list class="pa-1">
                <v-list-tile avatar>
                    <v-list-tile-avatar>
                        <img src="https://randomuser.me/api/potraits/men/85.jpg">
                    </v-list-tile-avatar>

                    <v-list-tile-content>
                        <v-list-tile-title>Jhon Leider</v-list-tile-title>
                    </v-list-tile-content>
                </v-list-tile>
            </v-list>
            <v-list class="pt-0" dense>
                <v-divider></v-divider>
                
                <v-list-tile
                    v-for="item in items"
                    :key="item.title">
                    <v-list-tile-action>
                        <v-icon>{{ item.icon }}</v-icon>
                    </v-list-tile-action>

                    <v-list-tile-content>
                        <v-list-tile-title>{{ item.title }}</v-list-tile-title>
                    </v-list-tile-content>
                </v-list-tile>
            </v-list>
            </v-navigation-drawer>
        </div>
    </v-toolbar>
</template>

<script>
    export default {
        data() {
            return {
                drawer: null,
                items: [
                    { title: 'Home', icon: 'dashboard' },
                    { title: 'about', icon: 'question_answer' }
                ]
            }
        }
    }
</script>