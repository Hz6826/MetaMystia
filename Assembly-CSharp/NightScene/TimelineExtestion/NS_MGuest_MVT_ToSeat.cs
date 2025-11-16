using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000203 RID: 515
	public class NS_MGuest_MVT_ToSeat : PlayableAsset
	{
		// Token: 0x06003D3F RID: 15679 RVA: 0x0016E390 File Offset: 0x0016C590
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_MVT_ToSeat()
		{
			Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_MVT_ToSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr);
			NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr, "label");
			NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_mood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr, "mood");
			NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr, "deskCode");
			NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr, "shouldWaitForFinish");
			NS_MGuest_MVT_ToSeat.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr, 100674560);
			NS_MGuest_MVT_ToSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr, 100674561);
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x0016E438 File Offset: 0x0016C638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137151, XrefRangeEnd = 137170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_MVT_ToSeat.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x0016E4A0 File Offset: 0x0016C6A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_MVT_ToSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_ToSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x0002244B File Offset: 0x0002064B
		public NS_MGuest_MVT_ToSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x0016E4DC File Offset: 0x0016C6DC
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00022454 File Offset: 0x00020654
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x0016E504 File Offset: 0x0016C704
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00022473 File Offset: 0x00020673
		public unsafe int mood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_mood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_mood)) = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x0016E52C File Offset: 0x0016C72C
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x0002248E File Offset: 0x0002068E
		public unsafe int deskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_deskCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_deskCode)) = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x0016E554 File Offset: 0x0016C754
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x000224A9 File Offset: 0x000206A9
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeFieldInfoPtr_mood;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr_deskCode;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
