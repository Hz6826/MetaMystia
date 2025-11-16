using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x0200039B RID: 923
	public class NoteBookAlbumPannel : MultiLayerUISubPanel<NoteBookMainPannel, NoteBookAlbumPannel, NoteBookAlbumPannel.AlbumType>
	{
		// Token: 0x06006F0C RID: 28428 RVA: 0x00210630 File Offset: 0x0020E830
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookAlbumPannel()
		{
			Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookAlbumPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr);
			NoteBookAlbumPannel.NativeFieldInfoPtr_GuestSubPanelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GuestSubPanelParent");
			NoteBookAlbumPannel.NativeFieldInfoPtr_ItemSubPanelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "ItemSubPanelParent");
			NoteBookAlbumPannel.NativeFieldInfoPtr_GotoGuestBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GotoGuestBtn");
			NoteBookAlbumPannel.NativeFieldInfoPtr_GotoFoodBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GotoFoodBtn");
			NoteBookAlbumPannel.NativeFieldInfoPtr_GotoBeverageBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GotoBeverageBtn");
			NoteBookAlbumPannel.NativeFieldInfoPtr_GotoIngredientBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GotoIngredientBtn");
			NoteBookAlbumPannel.NativeFieldInfoPtr_GotoKitchenwareBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GotoKitchenwareBtn");
			NoteBookAlbumPannel.NativeFieldInfoPtr_GotoItemBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "GotoItemBtn");
			NoteBookAlbumPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, 100685969);
			NoteBookAlbumPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, 100685970);
			NoteBookAlbumPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_AlbumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, 100685971);
			NoteBookAlbumPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, 100685972);
			NoteBookAlbumPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, 100685973);
			NoteBookAlbumPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, 100685974);
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06006F0D RID: 28429 RVA: 0x00210778 File Offset: 0x0020E978
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x002107C0 File Offset: 0x0020E9C0
		public unsafe override IEnumerable<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277824, XrefRangeEnd = 277830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x0021080C File Offset: 0x0020EA0C
		public unsafe override NoteBookAlbumPannel.AlbumType DefaultPanelSelection
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_AlbumType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x00210854 File Offset: 0x0020EA54
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x00210898 File Offset: 0x0020EA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277830, XrefRangeEnd = 277841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x002108D4 File Offset: 0x0020EAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277841, XrefRangeEnd = 277844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookAlbumPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x0003C35C File Offset: 0x0003A55C
		public NoteBookAlbumPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x00210910 File Offset: 0x0020EB10
		// (set) Token: 0x06006F15 RID: 28437 RVA: 0x0003C365 File Offset: 0x0003A565
		public unsafe NoteBookAlbumGuestSubPannel GuestSubPanelParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GuestSubPanelParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GuestSubPanelParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06006F16 RID: 28438 RVA: 0x00210940 File Offset: 0x0020EB40
		// (set) Token: 0x06006F17 RID: 28439 RVA: 0x0003C384 File Offset: 0x0003A584
		public unsafe NoteBookAlbumItemSubPannel ItemSubPanelParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_ItemSubPanelParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumItemSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_ItemSubPanelParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x00210970 File Offset: 0x0020EB70
		// (set) Token: 0x06006F19 RID: 28441 RVA: 0x0003C3A3 File Offset: 0x0003A5A3
		public unsafe UIButtonToggle GotoGuestBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoGuestBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoGuestBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x002109A0 File Offset: 0x0020EBA0
		// (set) Token: 0x06006F1B RID: 28443 RVA: 0x0003C3C2 File Offset: 0x0003A5C2
		public unsafe UIButtonToggle GotoFoodBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoFoodBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoFoodBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x002109D0 File Offset: 0x0020EBD0
		// (set) Token: 0x06006F1D RID: 28445 RVA: 0x0003C3E1 File Offset: 0x0003A5E1
		public unsafe UIButtonToggle GotoBeverageBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoBeverageBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoBeverageBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06006F1E RID: 28446 RVA: 0x00210A00 File Offset: 0x0020EC00
		// (set) Token: 0x06006F1F RID: 28447 RVA: 0x0003C400 File Offset: 0x0003A600
		public unsafe UIButtonToggle GotoIngredientBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoIngredientBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoIngredientBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x00210A30 File Offset: 0x0020EC30
		// (set) Token: 0x06006F21 RID: 28449 RVA: 0x0003C41F File Offset: 0x0003A61F
		public unsafe UIButtonToggle GotoKitchenwareBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoKitchenwareBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoKitchenwareBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x00210A60 File Offset: 0x0020EC60
		// (set) Token: 0x06006F23 RID: 28451 RVA: 0x0003C43E File Offset: 0x0003A63E
		public unsafe UIButtonToggle GotoItemBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoItemBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel.NativeFieldInfoPtr_GotoItemBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004994 RID: 18836
		private static readonly IntPtr NativeFieldInfoPtr_GuestSubPanelParent;

		// Token: 0x04004995 RID: 18837
		private static readonly IntPtr NativeFieldInfoPtr_ItemSubPanelParent;

		// Token: 0x04004996 RID: 18838
		private static readonly IntPtr NativeFieldInfoPtr_GotoGuestBtn;

		// Token: 0x04004997 RID: 18839
		private static readonly IntPtr NativeFieldInfoPtr_GotoFoodBtn;

		// Token: 0x04004998 RID: 18840
		private static readonly IntPtr NativeFieldInfoPtr_GotoBeverageBtn;

		// Token: 0x04004999 RID: 18841
		private static readonly IntPtr NativeFieldInfoPtr_GotoIngredientBtn;

		// Token: 0x0400499A RID: 18842
		private static readonly IntPtr NativeFieldInfoPtr_GotoKitchenwareBtn;

		// Token: 0x0400499B RID: 18843
		private static readonly IntPtr NativeFieldInfoPtr_GotoItemBtn;

		// Token: 0x0400499C RID: 18844
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x0400499D RID: 18845
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0;

		// Token: 0x0400499E RID: 18846
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_AlbumType_0;

		// Token: 0x0400499F RID: 18847
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x040049A0 RID: 18848
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040049A1 RID: 18849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EDC RID: 3804
		public enum AlbumType
		{
			// Token: 0x0400A91D RID: 43293
			Guest,
			// Token: 0x0400A91E RID: 43294
			Food,
			// Token: 0x0400A91F RID: 43295
			Beverage,
			// Token: 0x0400A920 RID: 43296
			Ingredient,
			// Token: 0x0400A921 RID: 43297
			Kitchenware,
			// Token: 0x0400A922 RID: 43298
			Item
		}

		// Token: 0x02000EDD RID: 3805
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumPannel+<get_GetData>d__12")]
		public sealed class _get_GetData_d__12 : Object
		{
			// Token: 0x06010B77 RID: 68471 RVA: 0x003DE398 File Offset: 0x003DC598
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__12()
			{
				Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumPannel>.NativeClassPtr, "<get_GetData>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr);
				NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, "<>1__state");
				NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, "<>2__current");
				NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, "<>l__initialThreadId");
				NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, "<>4__this");
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685975);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685976);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685977);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685978);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685979);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685980);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685981);
				NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr, 100685982);
			}

			// Token: 0x06010B78 RID: 68472 RVA: 0x003DE4B4 File Offset: 0x003DC6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumPannel._get_GetData_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B79 RID: 68473 RVA: 0x003DE4FC File Offset: 0x003DC6FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B7A RID: 68474 RVA: 0x003DE530 File Offset: 0x003DC730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277809, XrefRangeEnd = 277813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005722 RID: 22306
			// (get) Token: 0x06010B7B RID: 68475 RVA: 0x003DE56C File Offset: 0x003DC76C
			public unsafe ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>> prop_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>(pointer);
				}
			}

			// Token: 0x06010B7C RID: 68476 RVA: 0x003DE5A4 File Offset: 0x003DC7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277813, XrefRangeEnd = 277819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005723 RID: 22307
			// (get) Token: 0x06010B7D RID: 68477 RVA: 0x003DE5D8 File Offset: 0x003DC7D8
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277819, XrefRangeEnd = 277822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010B7E RID: 68478 RVA: 0x003DE618 File Offset: 0x003DC818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277822, XrefRangeEnd = 277824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>>>(intPtr3) : null;
			}

			// Token: 0x06010B7F RID: 68479 RVA: 0x003DE658 File Offset: 0x003DC858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumPannel._get_GetData_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010B80 RID: 68480 RVA: 0x00091C00 File Offset: 0x0008FE00
			public _get_GetData_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700571E RID: 22302
			// (get) Token: 0x06010B81 RID: 68481 RVA: 0x003DE698 File Offset: 0x003DC898
			// (set) Token: 0x06010B82 RID: 68482 RVA: 0x00091C09 File Offset: 0x0008FE09
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700571F RID: 22303
			// (get) Token: 0x06010B83 RID: 68483 RVA: 0x003DE6C0 File Offset: 0x003DC8C0
			// (set) Token: 0x06010B84 RID: 68484 RVA: 0x00091C24 File Offset: 0x0008FE24
			public ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___2__current);
					return new ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005720 RID: 22304
			// (get) Token: 0x06010B85 RID: 68485 RVA: 0x003DE6F0 File Offset: 0x003DC8F0
			// (set) Token: 0x06010B86 RID: 68486 RVA: 0x00091C52 File Offset: 0x0008FE52
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17005721 RID: 22305
			// (get) Token: 0x06010B87 RID: 68487 RVA: 0x003DE718 File Offset: 0x003DC918
			// (set) Token: 0x06010B88 RID: 68488 RVA: 0x00091C6D File Offset: 0x0008FE6D
			public unsafe NoteBookAlbumPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumPannel._get_GetData_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A923 RID: 43299
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A924 RID: 43300
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A925 RID: 43301
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400A926 RID: 43302
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A927 RID: 43303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A928 RID: 43304
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A929 RID: 43305
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A92A RID: 43306
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0;

			// Token: 0x0400A92B RID: 43307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A92C RID: 43308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A92D RID: 43309
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_AlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumPannel_0;

			// Token: 0x0400A92E RID: 43310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
