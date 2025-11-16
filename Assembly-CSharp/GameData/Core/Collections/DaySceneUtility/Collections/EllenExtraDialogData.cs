using System;
using Common.UI.DLC5_EllenShopPanel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x0200029E RID: 670
	public class EllenExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06005541 RID: 21825 RVA: 0x001BE0B4 File Offset: 0x001BC2B4
		// Note: this type is marked as 'beforefieldinit'.
		static EllenExtraDialogData()
		{
			Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "EllenExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr);
			EllenExtraDialogData.NativeFieldInfoPtr_needLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "needLevel");
			EllenExtraDialogData.NativeFieldInfoPtr_ELLEN_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "ELLEN_ID");
			EllenExtraDialogData.NativeFieldInfoPtr_DLC5_ELLEN_SHOP_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "DLC5_ELLEN_SHOP_TITLE");
			EllenExtraDialogData.NativeFieldInfoPtr_m_OpenShopDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "m_OpenShopDialog");
			EllenExtraDialogData.NativeFieldInfoPtr_m_EndDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "m_EndDialog");
			EllenExtraDialogData.NativeFieldInfoPtr_m_FinishShoppingDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "m_FinishShoppingDialog");
			EllenExtraDialogData.NativeFieldInfoPtr_m_EllenShopPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "m_EllenShopPanel");
			EllenExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, 100680709);
			EllenExtraDialogData.NativeMethodInfoPtr_Shop_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, 100680710);
			EllenExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, 100680711);
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x001BE1AC File Offset: 0x001BC3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213007, XrefRangeEnd = 213024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpecialGuestExtraDialogData(out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelection, out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EllenExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x001BE22C File Offset: 0x001BC42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213024, XrefRangeEnd = 213050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shop(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.NativeMethodInfoPtr_Shop_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x001BE2BC File Offset: 0x001BC4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213050, XrefRangeEnd = 213051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EllenExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x0002DDCC File Offset: 0x0002BFCC
		public EllenExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x001BE2F8 File Offset: 0x001BC4F8
		// (set) Token: 0x06005547 RID: 21831 RVA: 0x0002DDD5 File Offset: 0x0002BFD5
		public unsafe int needLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_needLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_needLevel)) = value;
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06005548 RID: 21832 RVA: 0x001BE320 File Offset: 0x001BC520
		// (set) Token: 0x06005549 RID: 21833 RVA: 0x0002DDF0 File Offset: 0x0002BFF0
		public unsafe static int ELLEN_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EllenExtraDialogData.NativeFieldInfoPtr_ELLEN_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EllenExtraDialogData.NativeFieldInfoPtr_ELLEN_ID, (void*)(&value));
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x0600554A RID: 21834 RVA: 0x001BE33C File Offset: 0x001BC53C
		// (set) Token: 0x0600554B RID: 21835 RVA: 0x0002DDFE File Offset: 0x0002BFFE
		public unsafe static string DLC5_ELLEN_SHOP_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EllenExtraDialogData.NativeFieldInfoPtr_DLC5_ELLEN_SHOP_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EllenExtraDialogData.NativeFieldInfoPtr_DLC5_ELLEN_SHOP_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600554C RID: 21836 RVA: 0x001BE35C File Offset: 0x001BC55C
		// (set) Token: 0x0600554D RID: 21837 RVA: 0x0002DE10 File Offset: 0x0002C010
		public unsafe Il2CppReferenceArray<DialogPackage> m_OpenShopDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_OpenShopDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_OpenShopDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x001BE38C File Offset: 0x001BC58C
		// (set) Token: 0x0600554F RID: 21839 RVA: 0x0002DE2F File Offset: 0x0002C02F
		public unsafe Il2CppReferenceArray<DialogPackage> m_EndDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_EndDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_EndDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x001BE3BC File Offset: 0x001BC5BC
		// (set) Token: 0x06005551 RID: 21841 RVA: 0x0002DE4E File Offset: 0x0002C04E
		public unsafe Il2CppReferenceArray<DialogPackage> m_FinishShoppingDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_FinishShoppingDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_FinishShoppingDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x001BE3EC File Offset: 0x001BC5EC
		// (set) Token: 0x06005553 RID: 21843 RVA: 0x0002DE6D File Offset: 0x0002C06D
		public unsafe AssetReference m_EllenShopPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_EllenShopPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.NativeFieldInfoPtr_m_EllenShopPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003940 RID: 14656
		private static readonly IntPtr NativeFieldInfoPtr_needLevel;

		// Token: 0x04003941 RID: 14657
		private static readonly IntPtr NativeFieldInfoPtr_ELLEN_ID;

		// Token: 0x04003942 RID: 14658
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_ELLEN_SHOP_TITLE;

		// Token: 0x04003943 RID: 14659
		private static readonly IntPtr NativeFieldInfoPtr_m_OpenShopDialog;

		// Token: 0x04003944 RID: 14660
		private static readonly IntPtr NativeFieldInfoPtr_m_EndDialog;

		// Token: 0x04003945 RID: 14661
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishShoppingDialog;

		// Token: 0x04003946 RID: 14662
		private static readonly IntPtr NativeFieldInfoPtr_m_EllenShopPanel;

		// Token: 0x04003947 RID: 14663
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003948 RID: 14664
		private static readonly IntPtr NativeMethodInfoPtr_Shop_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003949 RID: 14665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C4D RID: 3149
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.EllenExtraDialogData+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600E3A3 RID: 58275 RVA: 0x0036CAFC File Offset: 0x0036ACFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EllenExtraDialogData>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr);
				EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "specialNPCInteractData");
				EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<>9__2");
				EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680712);
				EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__Shop_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680713);
				EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__Shop_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680714);
				EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, 100680715);
			}

			// Token: 0x0600E3A4 RID: 58276 RVA: 0x0036CBB4 File Offset: 0x0036ADB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3A5 RID: 58277 RVA: 0x0036CBF0 File Offset: 0x0036ADF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212974, XrefRangeEnd = 212988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Shop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__Shop_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3A6 RID: 58278 RVA: 0x0036CC24 File Offset: 0x0036AE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212988, XrefRangeEnd = 213001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Shop_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr__Shop_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3A7 RID: 58279 RVA: 0x0036CC58 File Offset: 0x0036AE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213001, XrefRangeEnd = 213007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x0600E3A8 RID: 58280 RVA: 0x0007968E File Offset: 0x0007788E
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049E5 RID: 18917
			// (get) Token: 0x0600E3A9 RID: 58281 RVA: 0x0036CC90 File Offset: 0x0036AE90
			// (set) Token: 0x0600E3AA RID: 58282 RVA: 0x00079697 File Offset: 0x00077897
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E6 RID: 18918
			// (get) Token: 0x0600E3AB RID: 58283 RVA: 0x0036CCC0 File Offset: 0x0036AEC0
			// (set) Token: 0x0600E3AC RID: 58284 RVA: 0x000796B6 File Offset: 0x000778B6
			public unsafe EllenExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EllenExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E7 RID: 18919
			// (get) Token: 0x0600E3AD RID: 58285 RVA: 0x0036CCF0 File Offset: 0x0036AEF0
			// (set) Token: 0x0600E3AE RID: 58286 RVA: 0x000796D5 File Offset: 0x000778D5
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400918A RID: 37258
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x0400918B RID: 37259
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400918C RID: 37260
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400918D RID: 37261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400918E RID: 37262
			private static readonly IntPtr NativeMethodInfoPtr__Shop_b__0_Internal_Void_0;

			// Token: 0x0400918F RID: 37263
			private static readonly IntPtr NativeMethodInfoPtr__Shop_b__2_Internal_Void_0;

			// Token: 0x04009190 RID: 37264
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0;

			// Token: 0x02001058 RID: 4184
			[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.EllenExtraDialogData+<>c__DisplayClass8_0+<<Shop>g__OpenEllenShop|1>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique : ValueType
			{
				// Token: 0x06011E30 RID: 73264 RVA: 0x00417644 File Offset: 0x00415844
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique()
				{
					Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0>.NativeClassPtr, "<<Shop>g__OpenEllenShop|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr);
					EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr, "<>1__state");
					EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr, "<>t__builder");
					EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr, "<>4__this");
					EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr, "<>u__1");
					EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr, 100680716);
					EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr, 100680717);
				}

				// Token: 0x06011E31 RID: 73265 RVA: 0x004176E8 File Offset: 0x004158E8
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 212971, RefRangeEnd = 212974, XrefRangeStart = 212914, XrefRangeEnd = 212971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E32 RID: 73266 RVA: 0x00417720 File Offset: 0x00415920
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E33 RID: 73267 RVA: 0x0009B5E0 File Offset: 0x000997E0
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06011E34 RID: 73268 RVA: 0x0009B5E9 File Offset: 0x000997E9
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005D3C RID: 23868
				// (get) Token: 0x06011E35 RID: 73269 RVA: 0x00417768 File Offset: 0x00415968
				// (set) Token: 0x06011E36 RID: 73270 RVA: 0x0009B5FB File Offset: 0x000997FB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D3D RID: 23869
				// (get) Token: 0x06011E37 RID: 73271 RVA: 0x00417790 File Offset: 0x00415990
				// (set) Token: 0x06011E38 RID: 73272 RVA: 0x0009B616 File Offset: 0x00099816
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005D3E RID: 23870
				// (get) Token: 0x06011E39 RID: 73273 RVA: 0x004177C0 File Offset: 0x004159C0
				// (set) Token: 0x06011E3A RID: 73274 RVA: 0x0009B644 File Offset: 0x00099844
				public unsafe EllenExtraDialogData.__c__DisplayClass8_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<EllenExtraDialogData.__c__DisplayClass8_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D3F RID: 23871
				// (get) Token: 0x06011E3B RID: 73275 RVA: 0x004177F0 File Offset: 0x004159F0
				// (set) Token: 0x06011E3C RID: 73276 RVA: 0x0009B663 File Offset: 0x00099863
				public UniTask<DLC5_EllenShopPanel>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___u__1);
						return new UniTask<DLC5_EllenShopPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_EllenShopPanel>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EllenExtraDialogData.__c__DisplayClass8_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1DLUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_EllenShopPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B4C9 RID: 46281
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B4CA RID: 46282
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B4CB RID: 46283
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B4CC RID: 46284
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B4CD RID: 46285
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B4CE RID: 46286
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}
	}
}
