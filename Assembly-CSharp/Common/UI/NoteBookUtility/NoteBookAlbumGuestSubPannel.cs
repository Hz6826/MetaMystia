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
	// Token: 0x02000398 RID: 920
	public class NoteBookAlbumGuestSubPannel : MultiLayerUISubPanel<NoteBookAlbumPannel, NoteBookAlbumGuestSubPannel, NoteBookAlbumGuestSubPannel.GuestAlbumType>
	{
		// Token: 0x06006E30 RID: 28208 RVA: 0x0020DE14 File Offset: 0x0020C014
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookAlbumGuestSubPannel()
		{
			Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookAlbumGuestSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr);
			NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "SubPannel");
			NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoNormalGuestBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "GotoNormalGuestBtn");
			NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoSpecialGuestBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "GotoSpecialGuestBtn");
			NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoParticularGuestBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "GotoParticularGuestBtn");
			NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoPartnerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "GotoPartnerBtn");
			NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoSpellCardBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "GotoSpellCardBtn");
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685859);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685860);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GuestAlbumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685861);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685862);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_UseSingleButtonForSwitch_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685863);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685864);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685865);
			NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, 100685866);
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x0020DF5C File Offset: 0x0020C15C
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x06006E32 RID: 28210 RVA: 0x0020DFA4 File Offset: 0x0020C1A4
		public unsafe override IEnumerable<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276152, XrefRangeEnd = 276158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x0020DFF0 File Offset: 0x0020C1F0
		public unsafe override NoteBookAlbumGuestSubPannel.GuestAlbumType DefaultPanelSelection
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GuestAlbumType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x06006E34 RID: 28212 RVA: 0x0020E038 File Offset: 0x0020C238
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276158, XrefRangeEnd = 276159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0020E07C File Offset: 0x0020C27C
		public unsafe override bool UseSingleButtonForSwitch
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_get_UseSingleButtonForSwitch_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x0020E0C4 File Offset: 0x0020C2C4
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x0020E10C File Offset: 0x0020C30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276159, XrefRangeEnd = 276168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x0020E148 File Offset: 0x0020C348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276168, XrefRangeEnd = 276171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookAlbumGuestSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x0003B95B File Offset: 0x00039B5B
		public NoteBookAlbumGuestSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x0020E184 File Offset: 0x0020C384
		// (set) Token: 0x06006E3B RID: 28219 RVA: 0x0003B964 File Offset: 0x00039B64
		public unsafe NoteBookAlbumGuestSubSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06006E3C RID: 28220 RVA: 0x0020E1B4 File Offset: 0x0020C3B4
		// (set) Token: 0x06006E3D RID: 28221 RVA: 0x0003B983 File Offset: 0x00039B83
		public unsafe UIButtonToggle GotoNormalGuestBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoNormalGuestBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoNormalGuestBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06006E3E RID: 28222 RVA: 0x0020E1E4 File Offset: 0x0020C3E4
		// (set) Token: 0x06006E3F RID: 28223 RVA: 0x0003B9A2 File Offset: 0x00039BA2
		public unsafe UIButtonToggle GotoSpecialGuestBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoSpecialGuestBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoSpecialGuestBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06006E40 RID: 28224 RVA: 0x0020E214 File Offset: 0x0020C414
		// (set) Token: 0x06006E41 RID: 28225 RVA: 0x0003B9C1 File Offset: 0x00039BC1
		public unsafe UIButtonToggle GotoParticularGuestBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoParticularGuestBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoParticularGuestBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06006E42 RID: 28226 RVA: 0x0020E244 File Offset: 0x0020C444
		// (set) Token: 0x06006E43 RID: 28227 RVA: 0x0003B9E0 File Offset: 0x00039BE0
		public unsafe UIButtonToggle GotoPartnerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoPartnerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoPartnerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x0020E274 File Offset: 0x0020C474
		// (set) Token: 0x06006E45 RID: 28229 RVA: 0x0003B9FF File Offset: 0x00039BFF
		public unsafe UIButtonToggle GotoSpellCardBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoSpellCardBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel.NativeFieldInfoPtr_GotoSpellCardBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004910 RID: 18704
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x04004911 RID: 18705
		private static readonly IntPtr NativeFieldInfoPtr_GotoNormalGuestBtn;

		// Token: 0x04004912 RID: 18706
		private static readonly IntPtr NativeFieldInfoPtr_GotoSpecialGuestBtn;

		// Token: 0x04004913 RID: 18707
		private static readonly IntPtr NativeFieldInfoPtr_GotoParticularGuestBtn;

		// Token: 0x04004914 RID: 18708
		private static readonly IntPtr NativeFieldInfoPtr_GotoPartnerBtn;

		// Token: 0x04004915 RID: 18709
		private static readonly IntPtr NativeFieldInfoPtr_GotoSpellCardBtn;

		// Token: 0x04004916 RID: 18710
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004917 RID: 18711
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0;

		// Token: 0x04004918 RID: 18712
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GuestAlbumType_0;

		// Token: 0x04004919 RID: 18713
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x0400491A RID: 18714
		private static readonly IntPtr NativeMethodInfoPtr_get_UseSingleButtonForSwitch_Protected_Virtual_get_Boolean_0;

		// Token: 0x0400491B RID: 18715
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x0400491C RID: 18716
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400491D RID: 18717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EC9 RID: 3785
		public enum GuestAlbumType
		{
			// Token: 0x0400A8AA RID: 43178
			SpecialGuest,
			// Token: 0x0400A8AB RID: 43179
			NormalGuest,
			// Token: 0x0400A8AC RID: 43180
			ParticularGuest,
			// Token: 0x0400A8AD RID: 43181
			Partner,
			// Token: 0x0400A8AE RID: 43182
			SpellCard
		}

		// Token: 0x02000ECA RID: 3786
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumGuestSubPannel+<get_GetData>d__10")]
		public sealed class _get_GetData_d__10 : Object
		{
			// Token: 0x06010AC3 RID: 68291 RVA: 0x003DBC80 File Offset: 0x003D9E80
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__10()
			{
				Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel>.NativeClassPtr, "<get_GetData>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, "<>1__state");
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, "<>2__current");
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, "<>l__initialThreadId");
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, "<>4__this");
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685867);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685868);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685869);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685870);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685871);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685872);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685873);
				NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr, 100685874);
			}

			// Token: 0x06010AC4 RID: 68292 RVA: 0x003DBD9C File Offset: 0x003D9F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumGuestSubPannel._get_GetData_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AC5 RID: 68293 RVA: 0x003DBDE4 File Offset: 0x003D9FE4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010AC6 RID: 68294 RVA: 0x003DBE18 File Offset: 0x003DA018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276137, XrefRangeEnd = 276141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170056F2 RID: 22258
			// (get) Token: 0x06010AC7 RID: 68295 RVA: 0x003DBE54 File Offset: 0x003DA054
			public unsafe ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>> prop_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>(pointer);
				}
			}

			// Token: 0x06010AC8 RID: 68296 RVA: 0x003DBE8C File Offset: 0x003DA08C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276141, XrefRangeEnd = 276147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170056F3 RID: 22259
			// (get) Token: 0x06010AC9 RID: 68297 RVA: 0x003DBEC0 File Offset: 0x003DA0C0
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276147, XrefRangeEnd = 276150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010ACA RID: 68298 RVA: 0x003DBF00 File Offset: 0x003DA100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276150, XrefRangeEnd = 276152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>>>(intPtr3) : null;
			}

			// Token: 0x06010ACB RID: 68299 RVA: 0x003DBF40 File Offset: 0x003DA140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010ACC RID: 68300 RVA: 0x00091746 File Offset: 0x0008F946
			public _get_GetData_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056EE RID: 22254
			// (get) Token: 0x06010ACD RID: 68301 RVA: 0x003DBF80 File Offset: 0x003DA180
			// (set) Token: 0x06010ACE RID: 68302 RVA: 0x0009174F File Offset: 0x0008F94F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170056EF RID: 22255
			// (get) Token: 0x06010ACF RID: 68303 RVA: 0x003DBFA8 File Offset: 0x003DA1A8
			// (set) Token: 0x06010AD0 RID: 68304 RVA: 0x0009176A File Offset: 0x0008F96A
			public ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___2__current);
					return new ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170056F0 RID: 22256
			// (get) Token: 0x06010AD1 RID: 68305 RVA: 0x003DBFD8 File Offset: 0x003DA1D8
			// (set) Token: 0x06010AD2 RID: 68306 RVA: 0x00091798 File Offset: 0x0008F998
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170056F1 RID: 22257
			// (get) Token: 0x06010AD3 RID: 68307 RVA: 0x003DC000 File Offset: 0x003DA200
			// (set) Token: 0x06010AD4 RID: 68308 RVA: 0x000917B3 File Offset: 0x0008F9B3
			public unsafe NoteBookAlbumGuestSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumGuestSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumGuestSubPannel._get_GetData_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8AF RID: 43183
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A8B0 RID: 43184
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A8B1 RID: 43185
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400A8B2 RID: 43186
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8B3 RID: 43187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A8B4 RID: 43188
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8B5 RID: 43189
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A8B6 RID: 43190
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0;

			// Token: 0x0400A8B7 RID: 43191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8B8 RID: 43192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A8B9 RID: 43193
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GuestAlbumType_UIButtonToggle_UISubPanel_1_NoteBookAlbumGuestSubPannel_0;

			// Token: 0x0400A8BA RID: 43194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
