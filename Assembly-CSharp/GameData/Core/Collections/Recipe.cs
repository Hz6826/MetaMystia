using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections
{
	// Token: 0x02000242 RID: 578
	[Serializable]
	public class Recipe : NonTradableObjectBase
	{
		// Token: 0x06004819 RID: 18457 RVA: 0x0019842C File Offset: 0x0019662C
		// Note: this type is marked as 'beforefieldinit'.
		static Recipe()
		{
			Il2CppClassPointerStore<Recipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Recipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recipe>.NativeClassPtr);
			Recipe.NativeFieldInfoPtr_foodID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe>.NativeClassPtr, "foodID");
			Recipe.NativeFieldInfoPtr_ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe>.NativeClassPtr, "ingredients");
			Recipe.NativeFieldInfoPtr_cookerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe>.NativeClassPtr, "cookerType");
			Recipe.NativeFieldInfoPtr_cookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe>.NativeClassPtr, "cookTime");
			Recipe.NativeFieldInfoPtr_cookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe>.NativeClassPtr, "cookCount");
			Recipe.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CookerType_Single_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677715);
			Recipe.NativeMethodInfoPtr_get_FoodID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677716);
			Recipe.NativeMethodInfoPtr_get_Food_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677717);
			Recipe.NativeMethodInfoPtr_get_Ingredients_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677718);
			Recipe.NativeMethodInfoPtr_get_CookerType_Public_get_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677719);
			Recipe.NativeMethodInfoPtr_get_BaseCookTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677720);
			Recipe.NativeMethodInfoPtr_get_CookTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677721);
			Recipe.NativeMethodInfoPtr_get_CookCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677722);
			Recipe.NativeMethodInfoPtr_set_CookCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677723);
			Recipe.NativeMethodInfoPtr_GetCookCountNum_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677724);
			Recipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677725);
			Recipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677726);
			Recipe.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677727);
			Recipe.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677728);
			Recipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677729);
			Recipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe>.NativeClassPtr, 100677730);
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x00198600 File Offset: 0x00196800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189737, XrefRangeEnd = 189739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recipe(int id, int foodID, Cooker.CookerType cookerType, float cookTime, Il2CppStructArray<int> ingredients) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recipe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref foodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookerType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CookerType_Single_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x00198684 File Offset: 0x00196884
		public unsafe int FoodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_FoodID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x001986C0 File Offset: 0x001968C0
		public unsafe Sellable Food
		{
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 189740, RefRangeEnd = 189816, XrefRangeStart = 189739, XrefRangeEnd = 189740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_Food_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x00198700 File Offset: 0x00196900
		public unsafe Il2CppStructArray<int> Ingredients
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_Ingredients_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x00198740 File Offset: 0x00196940
		public unsafe Cooker.CookerType CookerType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_CookerType_Public_get_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x0019877C File Offset: 0x0019697C
		public unsafe float BaseCookTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_BaseCookTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x001987B8 File Offset: 0x001969B8
		public unsafe float CookTime
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 189821, RefRangeEnd = 189827, XrefRangeStart = 189816, XrefRangeEnd = 189821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_CookTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x001987F4 File Offset: 0x001969F4
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x00198830 File Offset: 0x00196A30
		public unsafe int CookCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53318, RefRangeEnd = 53319, XrefRangeStart = 53318, XrefRangeEnd = 53319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_get_CookCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95701, RefRangeEnd = 95702, XrefRangeStart = 95701, XrefRangeEnd = 95702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_set_CookCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x00198870 File Offset: 0x00196A70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189829, RefRangeEnd = 189833, XrefRangeStart = 189827, XrefRangeEnd = 189829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookCountNum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_GetCookCountNum_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x001988A8 File Offset: 0x00196AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189833, XrefRangeEnd = 189842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Recipe other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x001988F8 File Offset: 0x00196AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189842, XrefRangeEnd = 189923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x0019893C File Offset: 0x00196B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189923, XrefRangeEnd = 189927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recipe.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00198994 File Offset: 0x00196B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189927, XrefRangeEnd = 189933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recipe.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x001989E0 File Offset: 0x00196BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189933, XrefRangeEnd = 189946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x00198A38 File Offset: 0x00196C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189946, XrefRangeEnd = 189958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x00025180 File Offset: 0x00023380
		public Recipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x00198A80 File Offset: 0x00196C80
		// (set) Token: 0x0600482C RID: 18476 RVA: 0x00025189 File Offset: 0x00023389
		public unsafe int foodID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_foodID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_foodID)) = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x00198AA8 File Offset: 0x00196CA8
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x000251A4 File Offset: 0x000233A4
		public unsafe Il2CppStructArray<int> ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x00198AD8 File Offset: 0x00196CD8
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x000251C3 File Offset: 0x000233C3
		public unsafe Cooker.CookerType cookerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_cookerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_cookerType)) = value;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x00198B00 File Offset: 0x00196D00
		// (set) Token: 0x06004832 RID: 18482 RVA: 0x000251DE File Offset: 0x000233DE
		public unsafe float cookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_cookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_cookTime)) = value;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x00198B28 File Offset: 0x00196D28
		// (set) Token: 0x06004834 RID: 18484 RVA: 0x000251F9 File Offset: 0x000233F9
		public unsafe int cookCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_cookCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recipe.NativeFieldInfoPtr_cookCount)) = value;
			}
		}

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeFieldInfoPtr_foodID;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeFieldInfoPtr_ingredients;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeFieldInfoPtr_cookerType;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeFieldInfoPtr_cookTime;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeFieldInfoPtr_cookCount;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CookerType_Single_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodID_Public_get_Int32_0;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeMethodInfoPtr_get_Food_Public_get_Sellable_0;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerType_Public_get_CookerType_0;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCookTime_Public_get_Single_0;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTime_Public_get_Single_0;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeMethodInfoPtr_get_CookCount_Public_get_Int32_0;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeMethodInfoPtr_set_CookCount_Public_set_Void_Int32_0;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeMethodInfoPtr_GetCookCountNum_Public_String_0;

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Recipe_0;

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x02000ABC RID: 2748
		public enum SortType
		{
			// Token: 0x0400845E RID: 33886
			CookTime,
			// Token: 0x0400845F RID: 33887
			CookCount,
			// Token: 0x04008460 RID: 33888
			ID,
			// Token: 0x04008461 RID: 33889
			Level,
			// Token: 0x04008462 RID: 33890
			Value,
			// Token: 0x04008463 RID: 33891
			Tag
		}

		// Token: 0x02000ABD RID: 2749
		[ObfuscatedName("GameData.Core.Collections.Recipe+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CDE1 RID: 52705 RVA: 0x0032BF84 File Offset: 0x0032A184
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Recipe>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr);
				Recipe.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr, "<>9");
				Recipe.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr, "<>9__24_0");
				Recipe.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr, "<>9__24_1");
				Recipe.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr, 100677732);
				Recipe.__c.NativeMethodInfoPtr__ToString_b__24_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr, 100677733);
				Recipe.__c.NativeMethodInfoPtr__ToString_b__24_1_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr, 100677734);
			}

			// Token: 0x0600CDE2 RID: 52706 RVA: 0x0032C028 File Offset: 0x0032A228
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recipe.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDE3 RID: 52707 RVA: 0x0032C064 File Offset: 0x0032A264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__24_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.__c.NativeMethodInfoPtr__ToString_b__24_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CDE4 RID: 52708 RVA: 0x0032C0A8 File Offset: 0x0032A2A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189734, XrefRangeEnd = 189737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__24_1(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recipe.__c.NativeMethodInfoPtr__ToString_b__24_1_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CDE5 RID: 52709 RVA: 0x0006E4A3 File Offset: 0x0006C6A3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EF RID: 17135
			// (get) Token: 0x0600CDE6 RID: 52710 RVA: 0x0032C104 File Offset: 0x0032A304
			// (set) Token: 0x0600CDE7 RID: 52711 RVA: 0x0006E4AC File Offset: 0x0006C6AC
			public unsafe static Recipe.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Recipe.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Recipe.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F0 RID: 17136
			// (get) Token: 0x0600CDE8 RID: 52712 RVA: 0x0032C12C File Offset: 0x0032A32C
			// (set) Token: 0x0600CDE9 RID: 52713 RVA: 0x0006E4BE File Offset: 0x0006C6BE
			public unsafe static Func<int, string> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Recipe.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Recipe.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F1 RID: 17137
			// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x0032C154 File Offset: 0x0032A354
			// (set) Token: 0x0600CDEB RID: 52715 RVA: 0x0006E4D0 File Offset: 0x0006C6D0
			public unsafe static Func<string, string, string> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Recipe.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Recipe.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008464 RID: 33892
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008465 RID: 33893
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04008466 RID: 33894
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x04008467 RID: 33895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008468 RID: 33896
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__24_0_Internal_String_Int32_0;

			// Token: 0x04008469 RID: 33897
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__24_1_Internal_String_String_String_0;
		}
	}
}
