<template>
    <v-navigation-drawer
            id="app-drawer"
            app
            dark
            floating
            persistent
            mobile-break-point="991"
            width="260"
    >

        <v-img
                src="img/sidebar-2.32103624.jpg"
                height="100%"
        >

            <v-layout
                    class="fill-height"
                    tag="v-list"
                    column
            >
                <v-list-tile avatar>
                    <v-list-tile-avatar
                            color="white"
                    >
                    </v-list-tile-avatar>
                    <v-list-tile-title class="title">
                        Vuetify MD
                    </v-list-tile-title>
                </v-list-tile>
                <v-divider/>
                <v-list-tile
                        v-if="responsive"
                >
                    <v-text-field
                            class="purple-input search-input"
                            label="Search..."
                            color="purple"
                    />
                </v-list-tile>
                <v-list-tile
                        v-for="(link, i) in links"
                        :key="i"
                        :to="link.to"
                        :active-class="color"
                        avatar
                        class="v-list-item"
                >
                    <v-list-tile-action>
                        <v-icon>{{ link.icon }}</v-icon>
                    </v-list-tile-action>
                    <v-list-tile-title
                            v-text="link.text"
                    />
                </v-list-tile>
            </v-layout>
        </v-img>

    </v-navigation-drawer>
</template>

<script>
    export default {

        computed : {
            color () {
                return "success";
            }
        },
        data () {
            return {
                logo: './img/vuetifylogo.png',
                links: [
                    {
                        to: '/',
                        icon: 'mdi-view-dashboard',
                        text: 'Home'
                    },
                    {
                        to: '/products',
                        icon: 'mdi-account',
                        text: 'Products'
                    }
                ],
                responsive: false
            }
        }
    }
</script>

<style scoped>

</style>