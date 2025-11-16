using System;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003DB RID: 987
	public class COM_CommonPannels_Open : PlayableAsset
	{
		// Token: 0x060075E4 RID: 30180 RVA: 0x00227790 File Offset: 0x00225990
		// Note: this type is marked as 'beforefieldinit'.
		static COM_CommonPannels_Open()
		{
			Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_CommonPannels_Open");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr);
			COM_CommonPannels_Open.NativeFieldInfoPtr_PannelOpenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr, "PannelOpenType");
			COM_CommonPannels_Open.NativeFieldInfoPtr_NoteBookGotoType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr, "NoteBookGotoType");
			COM_CommonPannels_Open.NativeFieldInfoPtr_StorageGotoType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr, "StorageGotoType");
			COM_CommonPannels_Open.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr, 100687471);
			COM_CommonPannels_Open.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr, 100687472);
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00227824 File Offset: 0x00225A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292477, XrefRangeEnd = 292489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_CommonPannels_Open.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x0022788C File Offset: 0x00225A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_CommonPannels_Open() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_CommonPannels_Open>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_CommonPannels_Open.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x0003FCAE File Offset: 0x0003DEAE
		public COM_CommonPannels_Open(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x060075E8 RID: 30184 RVA: 0x002278C8 File Offset: 0x00225AC8
		// (set) Token: 0x060075E9 RID: 30185 RVA: 0x0003FCB7 File Offset: 0x0003DEB7
		public unsafe COM_CommonPannels_Open_Behaviour.PannelType PannelOpenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open.NativeFieldInfoPtr_PannelOpenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open.NativeFieldInfoPtr_PannelOpenType)) = value;
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x060075EA RID: 30186 RVA: 0x002278F0 File Offset: 0x00225AF0
		// (set) Token: 0x060075EB RID: 30187 RVA: 0x0003FCD2 File Offset: 0x0003DED2
		public unsafe NoteBookMainPannel.GoToSpecificType NoteBookGotoType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open.NativeFieldInfoPtr_NoteBookGotoType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open.NativeFieldInfoPtr_NoteBookGotoType)) = value;
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x060075EC RID: 30188 RVA: 0x00227918 File Offset: 0x00225B18
		// (set) Token: 0x060075ED RID: 30189 RVA: 0x0003FCED File Offset: 0x0003DEED
		public unsafe StorageMainPannel.GoToSpecificType StorageGotoType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open.NativeFieldInfoPtr_StorageGotoType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open.NativeFieldInfoPtr_StorageGotoType)) = value;
			}
		}

		// Token: 0x04004E1C RID: 19996
		private static readonly IntPtr NativeFieldInfoPtr_PannelOpenType;

		// Token: 0x04004E1D RID: 19997
		private static readonly IntPtr NativeFieldInfoPtr_NoteBookGotoType;

		// Token: 0x04004E1E RID: 19998
		private static readonly IntPtr NativeFieldInfoPtr_StorageGotoType;

		// Token: 0x04004E1F RID: 19999
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E20 RID: 20000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
