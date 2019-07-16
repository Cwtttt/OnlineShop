﻿Vue.component('product-manager', {
    template: `
        <div>            
            <div v-if="!editing">
                <button class="button" @click="newProduct">Add new product</button>
                <table class="table">
                    <tr>
                        <th>Id</th>
                        <th>Product</th>
                        <th>Value</th>
                        <th></th>
                        <th></th>
                    </tr>
                    <tr v-for="(product, index) in products">
                        <td>{{product.id}} </td>
                        <td>{{product.name}}</td>
                        <td>{{product.value}}</td>
                        <td><a @click="editProduct(product.id, index)">Edit</a></td>
                        <td><a @click="deleteProduct(product.id, index)">Remove</a></td>
                    </tr>
                </table>
            </div>

            <div v-else>
                <div class="field">
                    <label class="label">Product Name</label>
                        <div class="control">
                            <input class="inpus" v-model="productModel.name" />
                        </div>
                </div>

                <div class="field">
                    <label class="label">Product Description</label>
                        <div class="control">
                            <input class="inpus" v-model="productModel.description" />
                        </div>
                </div>

                <div class="field">
                    <label class="label">Value</label>
                        <div class="control">
                            <input class="inpus" v-model="productModel.value" />
                        </div>
                </div>
                <button class="button is-success" v-on:click="createProduct" v-if="!productModel.id">Create product</button>
                <button class="button is-warning" v-on:click="updateProduct" v-else>Update product</button>
                <button class="button" v-on:click="cancel">Cancel</button>
            </div>
        </div>`,
    data() {
        return {
            objectIndex: 0,
            productModel: {
                id: 0,
                name: "Product Name",
                description: "Product Description",
                value: 1.99
            },
            loading: false,
            editing: false,
            products: []
        }
    },
    mounted() {
        this.getProducts();
    },
    methods: {
        getProduct(id) {
            this.loading = true;
            axios.get('/Admin/products/' + id)
                .then(res => {
                    console.log(res);
                    var product = res.data;
                    this.productModel = {
                        id: product.id,
                        name: product.name,
                        description: product.description,
                        value: product.value
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getProducts() {
            this.loading = true;
            axios.get('/Admin/products')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createProduct() {
            axios.post('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateProduct() {
            axios.put('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editProduct = false;
                });
        },
        deleteProduct(id, index) {
            this.loading = true;
            axios.delete('/Admin/products/' + id)
                .then(res => {
                    console.log(res);
                    this.products.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newProduct() {
            this.editing = true;
            this.productModel.id = 0;
        },
        editProduct(id, index) {
            this.objectIndex = index;
            this.getProduct(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});