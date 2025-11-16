using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x0200037E RID: 894
	public class DailyRecipePrinter : MonoBehaviour
	{
		// Token: 0x06006A16 RID: 27158 RVA: 0x00200A14 File Offset: 0x001FEC14
		// Note: this type is marked as 'beforefieldinit'.
		static DailyRecipePrinter()
		{
			Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DailyRecipePrinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr);
			DailyRecipePrinter.NativeFieldInfoPtr_recipeParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "recipeParent");
			DailyRecipePrinter.NativeFieldInfoPtr_recipeNullParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "recipeNullParent");
			DailyRecipePrinter.NativeFieldInfoPtr_beverageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "beverageParent");
			DailyRecipePrinter.NativeFieldInfoPtr_beverageNullParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "beverageNullParent");
			DailyRecipePrinter.NativeFieldInfoPtr_recipeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "recipeField");
			DailyRecipePrinter.NativeFieldInfoPtr_beverageField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "beverageField");
			DailyRecipePrinter.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "describer");
			DailyRecipePrinter.NativeFieldInfoPtr_check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "check");
			DailyRecipePrinter.NativeFieldInfoPtr_cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "cross");
			DailyRecipePrinter.NativeFieldInfoPtr_checkColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "checkColor");
			DailyRecipePrinter.NativeFieldInfoPtr_crossColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "crossColor");
			DailyRecipePrinter.NativeFieldInfoPtr_lockColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "lockColor");
			DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredBeverageInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "m_AllRegisteredBeverageInstances");
			DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredBeverageNullInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "m_AllRegisteredBeverageNullInstances");
			DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredRecipeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "m_AllRegisteredRecipeInstances");
			DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredRecipeNullInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "m_AllRegisteredRecipeNullInstances");
			DailyRecipePrinter.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, 100685273);
			DailyRecipePrinter.NativeMethodInfoPtr_UpdateDaily_Public_Void_Action_2_RecipePrinterData_UIButtonSimple_AdpScrollListFixedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, 100685274);
			DailyRecipePrinter.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, 100685275);
			DailyRecipePrinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, 100685276);
			DailyRecipePrinter.NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, 100685277);
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x00200BE8 File Offset: 0x001FEDE8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x00200C1C File Offset: 0x001FEE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270220, XrefRangeEnd = 270291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDaily(Action<DailyRecipePrinter.RecipePrinterData, UIButtonSimple> onObjectSpawnedCallback, AdpScrollListFixedComponent scroll = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onObjectSpawnedCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scroll);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.NativeMethodInfoPtr_UpdateDaily_Public_Void_Action_2_RecipePrinterData_UIButtonSimple_AdpScrollListFixedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00200C70 File Offset: 0x001FEE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270291, XrefRangeEnd = 270309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyRecipePrinter.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00200CAC File Offset: 0x001FEEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270309, XrefRangeEnd = 270333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyRecipePrinter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00200CE8 File Offset: 0x001FEEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270333, XrefRangeEnd = 270347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_String_PDM_0(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x000395AA File Offset: 0x000377AA
		public DailyRecipePrinter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x00200D24 File Offset: 0x001FEF24
		// (set) Token: 0x06006A1E RID: 27166 RVA: 0x000395B3 File Offset: 0x000377B3
		public unsafe GameObject recipeParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_recipeParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_recipeParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x00200D54 File Offset: 0x001FEF54
		// (set) Token: 0x06006A20 RID: 27168 RVA: 0x000395D2 File Offset: 0x000377D2
		public unsafe GameObject recipeNullParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_recipeNullParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_recipeNullParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x06006A21 RID: 27169 RVA: 0x00200D84 File Offset: 0x001FEF84
		// (set) Token: 0x06006A22 RID: 27170 RVA: 0x000395F1 File Offset: 0x000377F1
		public unsafe GameObject beverageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_beverageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_beverageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x06006A23 RID: 27171 RVA: 0x00200DB4 File Offset: 0x001FEFB4
		// (set) Token: 0x06006A24 RID: 27172 RVA: 0x00039610 File Offset: 0x00037810
		public unsafe GameObject beverageNullParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_beverageNullParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_beverageNullParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x00200DE4 File Offset: 0x001FEFE4
		// (set) Token: 0x06006A26 RID: 27174 RVA: 0x0003962F File Offset: 0x0003782F
		public unsafe RectTransform recipeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_recipeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_recipeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x00200E14 File Offset: 0x001FF014
		// (set) Token: 0x06006A28 RID: 27176 RVA: 0x0003964E File Offset: 0x0003784E
		public unsafe RectTransform beverageField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_beverageField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_beverageField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x06006A29 RID: 27177 RVA: 0x00200E44 File Offset: 0x001FF044
		// (set) Token: 0x06006A2A RID: 27178 RVA: 0x0003966D File Offset: 0x0003786D
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x00200E74 File Offset: 0x001FF074
		// (set) Token: 0x06006A2C RID: 27180 RVA: 0x0003968C File Offset: 0x0003788C
		public unsafe Sprite check
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_check);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_check), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x00200EA4 File Offset: 0x001FF0A4
		// (set) Token: 0x06006A2E RID: 27182 RVA: 0x000396AB File Offset: 0x000378AB
		public unsafe Sprite cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x06006A2F RID: 27183 RVA: 0x00200ED4 File Offset: 0x001FF0D4
		// (set) Token: 0x06006A30 RID: 27184 RVA: 0x000396CA File Offset: 0x000378CA
		public unsafe Color checkColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_checkColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_checkColor)) = value;
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x06006A31 RID: 27185 RVA: 0x00200EFC File Offset: 0x001FF0FC
		// (set) Token: 0x06006A32 RID: 27186 RVA: 0x000396E5 File Offset: 0x000378E5
		public unsafe Color crossColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_crossColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_crossColor)) = value;
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x06006A33 RID: 27187 RVA: 0x00200F24 File Offset: 0x001FF124
		// (set) Token: 0x06006A34 RID: 27188 RVA: 0x00039700 File Offset: 0x00037900
		public unsafe Color lockColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_lockColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_lockColor)) = value;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x06006A35 RID: 27189 RVA: 0x00200F4C File Offset: 0x001FF14C
		// (set) Token: 0x06006A36 RID: 27190 RVA: 0x0003971B File Offset: 0x0003791B
		public unsafe List<GameObject> m_AllRegisteredBeverageInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredBeverageInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredBeverageInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x00200F7C File Offset: 0x001FF17C
		// (set) Token: 0x06006A38 RID: 27192 RVA: 0x0003973A File Offset: 0x0003793A
		public unsafe List<GameObject> m_AllRegisteredBeverageNullInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredBeverageNullInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredBeverageNullInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x00200FAC File Offset: 0x001FF1AC
		// (set) Token: 0x06006A3A RID: 27194 RVA: 0x00039759 File Offset: 0x00037959
		public unsafe List<GameObject> m_AllRegisteredRecipeInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredRecipeInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredRecipeInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x00200FDC File Offset: 0x001FF1DC
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x00039778 File Offset: 0x00037978
		public unsafe List<GameObject> m_AllRegisteredRecipeNullInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredRecipeNullInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.NativeFieldInfoPtr_m_AllRegisteredRecipeNullInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400465C RID: 18012
		private static readonly IntPtr NativeFieldInfoPtr_recipeParent;

		// Token: 0x0400465D RID: 18013
		private static readonly IntPtr NativeFieldInfoPtr_recipeNullParent;

		// Token: 0x0400465E RID: 18014
		private static readonly IntPtr NativeFieldInfoPtr_beverageParent;

		// Token: 0x0400465F RID: 18015
		private static readonly IntPtr NativeFieldInfoPtr_beverageNullParent;

		// Token: 0x04004660 RID: 18016
		private static readonly IntPtr NativeFieldInfoPtr_recipeField;

		// Token: 0x04004661 RID: 18017
		private static readonly IntPtr NativeFieldInfoPtr_beverageField;

		// Token: 0x04004662 RID: 18018
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x04004663 RID: 18019
		private static readonly IntPtr NativeFieldInfoPtr_check;

		// Token: 0x04004664 RID: 18020
		private static readonly IntPtr NativeFieldInfoPtr_cross;

		// Token: 0x04004665 RID: 18021
		private static readonly IntPtr NativeFieldInfoPtr_checkColor;

		// Token: 0x04004666 RID: 18022
		private static readonly IntPtr NativeFieldInfoPtr_crossColor;

		// Token: 0x04004667 RID: 18023
		private static readonly IntPtr NativeFieldInfoPtr_lockColor;

		// Token: 0x04004668 RID: 18024
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRegisteredBeverageInstances;

		// Token: 0x04004669 RID: 18025
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRegisteredBeverageNullInstances;

		// Token: 0x0400466A RID: 18026
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRegisteredRecipeInstances;

		// Token: 0x0400466B RID: 18027
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRegisteredRecipeNullInstances;

		// Token: 0x0400466C RID: 18028
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400466D RID: 18029
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDaily_Public_Void_Action_2_RecipePrinterData_UIButtonSimple_AdpScrollListFixedComponent_0;

		// Token: 0x0400466E RID: 18030
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400466F RID: 18031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004670 RID: 18032
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0;

		// Token: 0x02000E8D RID: 3725
		public enum RecipePrinterType
		{
			// Token: 0x0400A72E RID: 42798
			Recipe,
			// Token: 0x0400A72F RID: 42799
			Beverage
		}

		// Token: 0x02000E8E RID: 3726
		[StructLayout(2)]
		public struct RecipePrinterData
		{
			// Token: 0x0601084A RID: 67658 RVA: 0x003D4768 File Offset: 0x003D2968
			// Note: this type is marked as 'beforefieldinit'.
			static RecipePrinterData()
			{
				Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "RecipePrinterData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr);
				DailyRecipePrinter.RecipePrinterData.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, "<Id>k__BackingField");
				DailyRecipePrinter.RecipePrinterData.NativeFieldInfoPtr__RecipePrinterType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, "<RecipePrinterType>k__BackingField");
				DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr__ctor_Public_Void_Int32_RecipePrinterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, 100685278);
				DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, 100685279);
				DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr_get_RecipePrinterType_Public_get_RecipePrinterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, 100685280);
				DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RecipePrinterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, 100685281);
			}

			// Token: 0x0601084B RID: 67659 RVA: 0x003D480C File Offset: 0x003D2A0C
			[CallerCount(104)]
			[CachedScanResults(RefRangeStart = 395, RefRangeEnd = 499, XrefRangeStart = 395, XrefRangeEnd = 499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipePrinterData(int id, DailyRecipePrinter.RecipePrinterType recipePrinterType)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipePrinterType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr__ctor_Public_Void_Int32_RecipePrinterType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700563C RID: 22076
			// (get) Token: 0x0601084C RID: 67660 RVA: 0x003D484C File Offset: 0x003D2A4C
			public unsafe int Id
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700563D RID: 22077
			// (get) Token: 0x0601084D RID: 67661 RVA: 0x003D487C File Offset: 0x003D2A7C
			public unsafe DailyRecipePrinter.RecipePrinterType RecipePrinterType
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr_get_RecipePrinterType_Public_get_RecipePrinterType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0601084E RID: 67662 RVA: 0x003D48AC File Offset: 0x003D2AAC
			[CallerCount(0)]
			public unsafe bool Equals(DailyRecipePrinter.RecipePrinterData other)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.RecipePrinterData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RecipePrinterData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601084F RID: 67663 RVA: 0x000903F6 File Offset: 0x0008E5F6
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DailyRecipePrinter.RecipePrinterData>.NativeClassPtr, ref this));
			}

			// Token: 0x0400A730 RID: 42800
			private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

			// Token: 0x0400A731 RID: 42801
			private static readonly IntPtr NativeFieldInfoPtr__RecipePrinterType_k__BackingField;

			// Token: 0x0400A732 RID: 42802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RecipePrinterType_0;

			// Token: 0x0400A733 RID: 42803
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

			// Token: 0x0400A734 RID: 42804
			private static readonly IntPtr NativeMethodInfoPtr_get_RecipePrinterType_Public_get_RecipePrinterType_0;

			// Token: 0x0400A735 RID: 42805
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RecipePrinterData_0;

			// Token: 0x0400A736 RID: 42806
			[FieldOffset(0)]
			public readonly int _Id_k__BackingField;

			// Token: 0x0400A737 RID: 42807
			[FieldOffset(4)]
			public readonly DailyRecipePrinter.RecipePrinterType _RecipePrinterType_k__BackingField;
		}

		// Token: 0x02000E8F RID: 3727
		[ObfuscatedName("Common.UI.DailyRecipePrinter+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x06010850 RID: 67664 RVA: 0x003D48EC File Offset: 0x003D2AEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr);
				DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, "scroll");
				DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_registeredCooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, "registeredCooker");
				DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_onObjectSpawnedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, "onObjectSpawnedCallback");
				DailyRecipePrinter.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, 100685282);
				DailyRecipePrinter.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_Recipe_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, 100685283);
				DailyRecipePrinter.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr, 100685284);
			}

			// Token: 0x06010851 RID: 67665 RVA: 0x003D49A4 File Offset: 0x003D2BA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010852 RID: 67666 RVA: 0x003D49E0 File Offset: 0x003D2BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270068, XrefRangeEnd = 270144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIButtonSimple_Recipe_PDM_0(UIButtonSimple visual, Recipe recipe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_Recipe_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010853 RID: 67667 RVA: 0x003D4A34 File Offset: 0x003D2C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270144, XrefRangeEnd = 270178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIButtonSimple_Sellable_PDM_0(UIButtonSimple visual, Sellable beverage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010854 RID: 67668 RVA: 0x00090408 File Offset: 0x0008E608
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700563E RID: 22078
			// (get) Token: 0x06010855 RID: 67669 RVA: 0x003D4A88 File Offset: 0x003D2C88
			// (set) Token: 0x06010856 RID: 67670 RVA: 0x00090411 File Offset: 0x0008E611
			public unsafe DailyRecipePrinter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700563F RID: 22079
			// (get) Token: 0x06010857 RID: 67671 RVA: 0x003D4AB8 File Offset: 0x003D2CB8
			// (set) Token: 0x06010858 RID: 67672 RVA: 0x00090430 File Offset: 0x0008E630
			public unsafe AdpScrollListFixedComponent scroll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_scroll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListFixedComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_scroll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005640 RID: 22080
			// (get) Token: 0x06010859 RID: 67673 RVA: 0x003D4AE8 File Offset: 0x003D2CE8
			// (set) Token: 0x0601085A RID: 67674 RVA: 0x0009044F File Offset: 0x0008E64F
			public unsafe IEnumerable<Cooker.CookerType> registeredCooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_registeredCooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_registeredCooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005641 RID: 22081
			// (get) Token: 0x0601085B RID: 67675 RVA: 0x003D4B18 File Offset: 0x003D2D18
			// (set) Token: 0x0601085C RID: 67676 RVA: 0x0009046E File Offset: 0x0008E66E
			public unsafe Action<DailyRecipePrinter.RecipePrinterData, UIButtonSimple> onObjectSpawnedCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_onObjectSpawnedCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DailyRecipePrinter.RecipePrinterData, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_0.NativeFieldInfoPtr_onObjectSpawnedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A738 RID: 42808
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A739 RID: 42809
			private static readonly IntPtr NativeFieldInfoPtr_scroll;

			// Token: 0x0400A73A RID: 42810
			private static readonly IntPtr NativeFieldInfoPtr_registeredCooker;

			// Token: 0x0400A73B RID: 42811
			private static readonly IntPtr NativeFieldInfoPtr_onObjectSpawnedCallback;

			// Token: 0x0400A73C RID: 42812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A73D RID: 42813
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_Recipe_PDM_0;

			// Token: 0x0400A73E RID: 42814
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_Sellable_PDM_0;
		}

		// Token: 0x02000E90 RID: 3728
		[ObfuscatedName("Common.UI.DailyRecipePrinter+<>c__DisplayClass18_1")]
		public sealed class __c__DisplayClass18_1 : Il2CppSystem.Object
		{
			// Token: 0x0601085D RID: 67677 RVA: 0x003D4B48 File Offset: 0x003D2D48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_1()
			{
				Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "<>c__DisplayClass18_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr);
				DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, "recipe");
				DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, "visual");
				DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_isLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, "isLocked");
				DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, "CS$<>8__locals1");
				DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, 100685285);
				DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, 100685286);
				DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, 100685287);
				DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, 100685288);
				DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, 100685289);
				DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__8_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr, 100685290);
			}

			// Token: 0x0601085E RID: 67678 RVA: 0x003D4C3C File Offset: 0x003D2E3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601085F RID: 67679 RVA: 0x003D4C78 File Offset: 0x003D2E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270178, XrefRangeEnd = 270192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010860 RID: 67680 RVA: 0x003D4CAC File Offset: 0x003D2EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270192, XrefRangeEnd = 270197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateDaily_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010861 RID: 67681 RVA: 0x003D4CF0 File Offset: 0x003D2EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270197, XrefRangeEnd = 270203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateDaily_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010862 RID: 67682 RVA: 0x003D4D34 File Offset: 0x003D2F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270203, XrefRangeEnd = 270206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateDaily_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010863 RID: 67683 RVA: 0x003D4D78 File Offset: 0x003D2F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270206, XrefRangeEnd = 270209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateDaily_b__8(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_1.NativeMethodInfoPtr__UpdateDaily_b__8_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010864 RID: 67684 RVA: 0x0009048D File Offset: 0x0008E68D
			public __c__DisplayClass18_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005642 RID: 22082
			// (get) Token: 0x06010865 RID: 67685 RVA: 0x003D4DBC File Offset: 0x003D2FBC
			// (set) Token: 0x06010866 RID: 67686 RVA: 0x00090496 File Offset: 0x0008E696
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005643 RID: 22083
			// (get) Token: 0x06010867 RID: 67687 RVA: 0x003D4DEC File Offset: 0x003D2FEC
			// (set) Token: 0x06010868 RID: 67688 RVA: 0x000904B5 File Offset: 0x0008E6B5
			public unsafe UIButtonSimple visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005644 RID: 22084
			// (get) Token: 0x06010869 RID: 67689 RVA: 0x003D4E1C File Offset: 0x003D301C
			// (set) Token: 0x0601086A RID: 67690 RVA: 0x000904D4 File Offset: 0x0008E6D4
			public unsafe bool isLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_isLocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_isLocked)) = value;
				}
			}

			// Token: 0x17005645 RID: 22085
			// (get) Token: 0x0601086B RID: 67691 RVA: 0x003D4E44 File Offset: 0x003D3044
			// (set) Token: 0x0601086C RID: 67692 RVA: 0x000904EF File Offset: 0x0008E6EF
			public unsafe DailyRecipePrinter.__c__DisplayClass18_0 field_Public___c__DisplayClass18_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinter.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A73F RID: 42815
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400A740 RID: 42816
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x0400A741 RID: 42817
			private static readonly IntPtr NativeFieldInfoPtr_isLocked;

			// Token: 0x0400A742 RID: 42818
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0;

			// Token: 0x0400A743 RID: 42819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A744 RID: 42820
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A745 RID: 42821
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__5_Internal_Void_Image_0;

			// Token: 0x0400A746 RID: 42822
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__6_Internal_Void_Image_0;

			// Token: 0x0400A747 RID: 42823
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__7_Internal_Void_Image_0;

			// Token: 0x0400A748 RID: 42824
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__8_Internal_Void_RectTransform_0;
		}

		// Token: 0x02000E91 RID: 3729
		[ObfuscatedName("Common.UI.DailyRecipePrinter+<>c__DisplayClass18_2")]
		public sealed class __c__DisplayClass18_2 : Il2CppSystem.Object
		{
			// Token: 0x0601086D RID: 67693 RVA: 0x003D4E74 File Offset: 0x003D3074
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_2()
			{
				Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "<>c__DisplayClass18_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr);
				DailyRecipePrinter.__c__DisplayClass18_2.NativeFieldInfoPtr_beverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr, "beverage");
				DailyRecipePrinter.__c__DisplayClass18_2.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr, "CS$<>8__locals2");
				DailyRecipePrinter.__c__DisplayClass18_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr, 100685291);
				DailyRecipePrinter.__c__DisplayClass18_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr, 100685292);
				DailyRecipePrinter.__c__DisplayClass18_2.NativeMethodInfoPtr__UpdateDaily_b__10_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr, 100685293);
			}

			// Token: 0x0601086E RID: 67694 RVA: 0x003D4F04 File Offset: 0x003D3104
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinter.__c__DisplayClass18_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601086F RID: 67695 RVA: 0x003D4F40 File Offset: 0x003D3140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270209, XrefRangeEnd = 270212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010870 RID: 67696 RVA: 0x003D4F74 File Offset: 0x003D3174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270212, XrefRangeEnd = 270217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateDaily_b__10(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c__DisplayClass18_2.NativeMethodInfoPtr__UpdateDaily_b__10_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010871 RID: 67697 RVA: 0x0009050E File Offset: 0x0008E70E
			public __c__DisplayClass18_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005646 RID: 22086
			// (get) Token: 0x06010872 RID: 67698 RVA: 0x003D4FB8 File Offset: 0x003D31B8
			// (set) Token: 0x06010873 RID: 67699 RVA: 0x00090517 File Offset: 0x0008E717
			public unsafe Sellable beverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_2.NativeFieldInfoPtr_beverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_2.NativeFieldInfoPtr_beverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005647 RID: 22087
			// (get) Token: 0x06010874 RID: 67700 RVA: 0x003D4FE8 File Offset: 0x003D31E8
			// (set) Token: 0x06010875 RID: 67701 RVA: 0x00090536 File Offset: 0x0008E736
			public unsafe DailyRecipePrinter.__c__DisplayClass18_0 field_Public___c__DisplayClass18_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_2.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinter.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinter.__c__DisplayClass18_2.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A749 RID: 42825
			private static readonly IntPtr NativeFieldInfoPtr_beverage;

			// Token: 0x0400A74A RID: 42826
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0;

			// Token: 0x0400A74B RID: 42827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A74C RID: 42828
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A74D RID: 42829
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__10_Internal_Void_RectTransform_0;
		}

		// Token: 0x02000E92 RID: 3730
		[ObfuscatedName("Common.UI.DailyRecipePrinter+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010876 RID: 67702 RVA: 0x003D5018 File Offset: 0x003D3218
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr);
				DailyRecipePrinter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr, "<>9");
				DailyRecipePrinter.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr, "<>9__18_0");
				DailyRecipePrinter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr, 100685295);
				DailyRecipePrinter.__c.NativeMethodInfoPtr__UpdateDaily_b__18_0_Internal_IEnumerable_1_CookerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr, 100685296);
			}

			// Token: 0x06010877 RID: 67703 RVA: 0x003D5094 File Offset: 0x003D3294
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010878 RID: 67704 RVA: 0x003D50D0 File Offset: 0x003D32D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270217, XrefRangeEnd = 270220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Cooker.CookerType> _UpdateDaily_b__18_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinter.__c.NativeMethodInfoPtr__UpdateDaily_b__18_0_Internal_IEnumerable_1_CookerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr3) : null;
			}

			// Token: 0x06010879 RID: 67705 RVA: 0x00090555 File Offset: 0x0008E755
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005648 RID: 22088
			// (get) Token: 0x0601087A RID: 67706 RVA: 0x003D511C File Offset: 0x003D331C
			// (set) Token: 0x0601087B RID: 67707 RVA: 0x0009055E File Offset: 0x0008E75E
			public unsafe static DailyRecipePrinter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyRecipePrinter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyRecipePrinter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005649 RID: 22089
			// (get) Token: 0x0601087C RID: 67708 RVA: 0x003D5144 File Offset: 0x003D3344
			// (set) Token: 0x0601087D RID: 67709 RVA: 0x00090570 File Offset: 0x0008E770
			public unsafe static Func<int, IEnumerable<Cooker.CookerType>> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyRecipePrinter.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<Cooker.CookerType>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyRecipePrinter.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A74E RID: 42830
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A74F RID: 42831
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400A750 RID: 42832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A751 RID: 42833
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__18_0_Internal_IEnumerable_1_CookerType_Int32_0;
		}
	}
}
