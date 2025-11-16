using System;
using Common.UI;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200012B RID: 299
	public class DLC5_RogueLike_RecipeDescriber : SellableDescriber
	{
		// Token: 0x0600226C RID: 8812 RVA: 0x0011064C File Offset: 0x0010E84C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLike_RecipeDescriber()
		{
			Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLike_RecipeDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr);
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredeintObjectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "ingredeintObjectParent");
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredientField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "ingredientField");
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "cookTime");
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookTime2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "cookTime2");
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "cookerName");
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookerVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "cookerVisual");
			DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredientObjectInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "ingredientObjectInstances");
			DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Recipe_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, 100669427);
			DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_InitializeElement_Private_Static_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, 100669428);
			DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, 100669429);
			DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, 100669430);
			DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, 100669431);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0011076C File Offset: 0x0010E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83510, XrefRangeEnd = 83548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Recipe detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Recipe_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x001107C8 File Offset: 0x0010E9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83548, XrefRangeEnd = 83569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeElement(UIElementCluster elements, int ingredient)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_InitializeElement_Private_Static_Void_UIElementCluster_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0011080C File Offset: 0x0010EA0C
		[CallerCount(0)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00110840 File Offset: 0x0010EA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83569, XrefRangeEnd = 83579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x0011087C File Offset: 0x0010EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83579, XrefRangeEnd = 83588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLike_RecipeDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00014EED File Offset: 0x000130ED
		public DLC5_RogueLike_RecipeDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x001108B8 File Offset: 0x0010EAB8
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x00014EF6 File Offset: 0x000130F6
		public unsafe GameObject ingredeintObjectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredeintObjectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredeintObjectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x001108E8 File Offset: 0x0010EAE8
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x00014F15 File Offset: 0x00013115
		public unsafe RectTransform ingredientField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredientField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredientField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x00110918 File Offset: 0x0010EB18
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x00014F34 File Offset: 0x00013134
		public unsafe TextMeshProUGUI cookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x00110948 File Offset: 0x0010EB48
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x00014F53 File Offset: 0x00013153
		public unsafe TextMeshProUGUI cookTime2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookTime2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookTime2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x00110978 File Offset: 0x0010EB78
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x00014F72 File Offset: 0x00013172
		public unsafe TextMeshProUGUI cookerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x001109A8 File Offset: 0x0010EBA8
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x00014F91 File Offset: 0x00013191
		public unsafe Image cookerVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookerVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_cookerVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x001109D8 File Offset: 0x0010EBD8
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x00014FB0 File Offset: 0x000131B0
		public unsafe List<GameObject> ingredientObjectInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredientObjectInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.NativeFieldInfoPtr_ingredientObjectInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeFieldInfoPtr_ingredeintObjectParent;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeFieldInfoPtr_ingredientField;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeFieldInfoPtr_cookTime;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_cookTime2;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_cookerName;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_cookerVisual;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_ingredientObjectInstances;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Recipe_CancellationToken_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_InitializeElement_Private_Static_Void_UIElementCluster_Int32_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000750 RID: 1872
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLike_RecipeDescriber+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x06009F68 RID: 40808 RVA: 0x002A16CC File Offset: 0x0029F8CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeFieldInfoPtr_ingredientText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr, "ingredientText");
				DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr, 100669432);
				DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeMethodInfoPtr__InitializeElement_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr, 100669433);
				DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeMethodInfoPtr__InitializeElement_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr, 100669434);
			}

			// Token: 0x06009F69 RID: 40809 RVA: 0x002A1748 File Offset: 0x0029F948
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F6A RID: 40810 RVA: 0x002A1784 File Offset: 0x0029F984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83508, XrefRangeEnd = 83510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeElement_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeMethodInfoPtr__InitializeElement_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F6B RID: 40811 RVA: 0x002A17C8 File Offset: 0x0029F9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeElement_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeMethodInfoPtr__InitializeElement_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F6C RID: 40812 RVA: 0x0005627E File Offset: 0x0005447E
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170034A6 RID: 13478
			// (get) Token: 0x06009F6D RID: 40813 RVA: 0x002A180C File Offset: 0x0029FA0C
			// (set) Token: 0x06009F6E RID: 40814 RVA: 0x00056287 File Offset: 0x00054487
			public unsafe ObjectLanguageBase ingredientText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeFieldInfoPtr_ingredientText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLike_RecipeDescriber.__c__DisplayClass8_0.NativeFieldInfoPtr_ingredientText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400675E RID: 26462
			private static readonly IntPtr NativeFieldInfoPtr_ingredientText;

			// Token: 0x0400675F RID: 26463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006760 RID: 26464
			private static readonly IntPtr NativeMethodInfoPtr__InitializeElement_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006761 RID: 26465
			private static readonly IntPtr NativeMethodInfoPtr__InitializeElement_b__1_Internal_Void_Image_0;
		}
	}
}
