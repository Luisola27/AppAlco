import { useEffect, useState } from "react";
import { GeneralCall } from "./GeneralCall";

export const GetCategories = () => {
    const [categories, setCategories] = useState([]);

    useEffect(() => {
        const fetchCategories = async () => {
            try{
                const categoriesResponse = await GeneralCall("Category");
                setCategories(categoriesResponse.data);
            } catch (error) {
                console.error("Error fetching categories", error);
            }
        };

        fetchCategories();
    }, []);

    return categories;
}