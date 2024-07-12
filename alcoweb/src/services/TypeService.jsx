import { useEffect, useState } from "react";
import { GeneralCall } from "./GeneralCall";

export const GetTypes = (categoryId) => {
    const [types, setType] = useState([]);
    useEffect(() => {
        if(categoryId && categoryId != 0 && categoryId != "Categoría") {
        const fetchTypes = async () => {
            try{
                const typesResponse = await GeneralCall(`CategoryType?idCategory=${categoryId}`);
                setType(typesResponse.data);
            } catch (error) {
                console.error("Error fetching types", error);
            }
        };
        fetchTypes();
    }
    }, [categoryId]);

    return types;
}