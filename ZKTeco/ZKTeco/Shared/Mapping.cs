using System;
using System.Collections.Generic;
using System.Linq;
using ZKTeco.Models;
using ZKTeco.Dtos.Category;
using System.Threading.Tasks;
using ZKTeco.Dtos.Product;
using ZKTeco.Dtos.ProductImage;
using ZKTeco.Dtos.Title;
using ZKTeco.Dto.AboutUs;

namespace ZKTeco.Shared
{
    public class Mapping
    {
        #region Category
        public Category MapCategoryToModel(CategoryDto dto)
        {
            if (dto != null)
            {
                return new Category
                {
                    CategoryNameArabic = dto.CategoryNameArabic,
                    CategoryNameEnglish = dto.CategoryNameEnglish,
                    CreatedDate = DateTime.Now,
                    Description = dto.Description,
                    Id = dto.Id,
                    ParentCategoryId = dto.ParentCategoryId
                };
            }
            else
                return new Category();
        }
        public CategoryDto MapCategoryToDto(Category model)
        {
            if (model != null)
            {
                return new CategoryDto
                {
                    CategoryNameArabic = model.CategoryNameArabic,
                    CategoryNameEnglish = model.CategoryNameEnglish,
                    CreatedDate = model.CreatedDate,
                    Description = model.Description,
                    Id = model.Id,
                    ParentCategoryId = model.ParentCategoryId
                };
            }
            else
                return new CategoryDto();
        }
        public FullCategoryDto MapCategoryToFullDto(Category model)
        {
            if (model != null)
            {
                return new FullCategoryDto
                {
                    CategoryNameArabic = model.CategoryNameArabic,
                    CategoryNameEnglish = model.CategoryNameEnglish,
                    CreatedDate = model.CreatedDate,
                    Description = model.Description,
                    Id = model.Id,
                    ParentCategoryId = model.ParentCategoryId,
                    ParentCategory = MapCategoryToDto(model.ParentCategory),
                    Products = model.Products.Select(MapProductToDto).ToList()
                };
            }
            else
                return new FullCategoryDto();
        }

        #endregion

        #region Product
        public Product MapProductToModel(ProductDto dto)
        {
            if (dto != null)
            {
                return new Product
                {
                    Id = dto.Id,
                    CategoryId = dto.CategoryId,
                    CreatedAt = DateTime.Now,
                    DescriptionAr = dto.DescriptionAr,
                    DescriptionEn = dto.DescriptionEn,
                    ProductNameAr = dto.ProductNameAr,
                    ProductNameEn = dto.ProductNameEn
                };
            }
            else
                return new Product();
        }
        public ProductDto MapProductToDto(Product model)
        {
            if (model != null)
            {
                return new ProductDto
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    CreatedAt = model.CreatedAt,
                    DescriptionAr = model.DescriptionAr,
                    DescriptionEn = model.DescriptionEn,
                    ProductNameAr = model.ProductNameAr,
                    ProductNameEn = model.ProductNameEn
                };
            }
            else
                return new ProductDto();
        }

        public FullProductDto MapProductToFullDto(Product model)
        {
            if (model != null)
            {
                return new FullProductDto
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    CreatedAt = model.CreatedAt,
                    DescriptionAr = model.DescriptionAr,
                    DescriptionEn = model.DescriptionEn,
                    ProductNameAr = model.ProductNameAr,
                    ProductNameEn = model.ProductNameEn,
                    Category = MapCategoryToDto(model.Category),
                    ProductImages = model.ProductImages.Select(MapProductImageToDto).ToList(),
                    Titles = model.Titles.Select(MapTitleToDto).ToList()
                };
            }
            else
                return new FullProductDto();
        }

        #endregion

        #region ProductImages
        public ProductImage MapProductImageToModel(ProductImageDto dto)
        {
            if (dto != null)
            {
                return new ProductImage
                {
                    Id = dto.Id,
                    ImageUrl = dto.ImageUrl,
                    ProductId = dto.ProductId
                };
            }
            else
                return new ProductImage();
        }
        public ProductImageDto MapProductImageToDto(ProductImage model)
        {
            if (model != null)
            {
                return new ProductImageDto
                {
                    Id = model.Id,
                    ImageUrl = model.ImageUrl,
                    ProductId = model.ProductId
                };
            }
            else
                return new ProductImageDto();
        }
        public FullProductImageDto MapProductImageToFullDto(ProductImage model)
        {
            if (model != null)
            {
                return new FullProductImageDto
                {
                    Id = model.Id,
                    ImageUrl = model.ImageUrl,
                    ProductId = model.ProductId,
                    ProductItem = MapProductToDto(model.Product)
                };
            }
            else
                return new FullProductImageDto();
        }

        #endregion

        #region Title
        public Title MapTitleToModel(TitleDto dto)
        {
            if (dto != null)
            {
                return new Title
                {
                    Id = dto.Id,
                    ContentInAr = dto.ContentInAr,
                    ContentInEn = dto.ContentInEn,
                    ProductId = dto.ProductId,
                    TitleNameAr = dto.TitleNameAr,
                    TitleNameEn = dto.TitleNameEn
                };
            }
            else
                return new Title();
        }
        public TitleDto MapTitleToDto(Title model)
        {
            if (model != null)
            {
                return new TitleDto
                {
                    Id = model.Id,
                    ContentInAr = model.ContentInAr,
                    ContentInEn = model.ContentInEn,
                    ProductId = model.ProductId,
                    TitleNameAr = model.TitleNameAr,
                    TitleNameEn = model.TitleNameEn
                };
            }
            else
                return new TitleDto();
        }
        public FullTitleDto MapTitleToFullDto(Title model)
        {
            if (model != null)
            {
                return new FullTitleDto
                {
                    Id = model.Id,
                    ContentInAr = model.ContentInAr,
                    ContentInEn = model.ContentInEn,
                    ProductId = model.ProductId,
                    TitleNameAr = model.TitleNameAr,
                    TitleNameEn = model.TitleNameEn,
                    ProductItem = MapProductToDto(model.Product)
                };
            }
            else
                return new FullTitleDto();
        }

        #endregion

        #region AboutUs
        public AboutU MapAboutUsToModel(AboutUsDto dto)
        {
            if (dto != null)
            {
                return new AboutU
                {
                    Id = dto.Id,
                    ParagraphAr = dto.paragraphAr,
                    ParagraphEn = dto.paragraphEn,
                    Photourl = dto.photourl,
                    SubtitleAr = dto.subtitleAr,
                    SubtitleEn = dto.subtitleEn,
                    TitleAr = dto.titleAr,
                    TitleEn = dto.titleEn
                };
            }
            else
                return new AboutU();
        }
        public AboutUsWithFileForm MapAboutUsToDto(AboutU model)
        {
            if (model != null)
            {
                return new AboutUsWithFileForm
                {
                    Id = model.Id,
                    paragraphAr = model.ParagraphAr,
                    paragraphEn = model.ParagraphEn,
                    photourl = model.Photourl,
                    subtitleAr = model.SubtitleAr,
                    subtitleEn = model.SubtitleEn,
                    titleAr = model.TitleAr,
                    titleEn = model.TitleEn
                };
            }
            else
                return new AboutUsWithFileForm();
        }

        #endregion

    }
}
