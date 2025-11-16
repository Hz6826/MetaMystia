using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Profile.SchedulerNodeCollection
{
	// Token: 0x02000335 RID: 821
	public class NewsNode : SchedulerNode
	{
		// Token: 0x06006111 RID: 24849 RVA: 0x001E2654 File Offset: 0x001E0854
		// Note: this type is marked as 'beforefieldinit'.
		static NewsNode()
		{
			Il2CppClassPointerStore<NewsNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile.SchedulerNodeCollection", "NewsNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsNode>.NativeClassPtr);
			NewsNode.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsNode>.NativeClassPtr, 100683319);
			NewsNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsNode>.NativeClassPtr, 100683320);
			NewsNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsNode>.NativeClassPtr, 100683321);
			NewsNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsNode>.NativeClassPtr, 100683322);
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x001E26D4 File Offset: 0x001E08D4
		[CallerCount(0)]
		public unsafe override SchedulerNode.NodeType GetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewsNode.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x001E271C File Offset: 0x001E091C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240523, XrefRangeEnd = 240529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type InternalGetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewsNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x001E2768 File Offset: 0x001E0968
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostIntializeClone(SchedulerNode instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewsNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x001E27B8 File Offset: 0x001E09B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewsNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewsNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00034A3D File Offset: 0x00032C3D
		public NewsNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400404A RID: 16458
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0;

		// Token: 0x0400404B RID: 16459
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0;

		// Token: 0x0400404C RID: 16460
		private static readonly IntPtr NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0;

		// Token: 0x0400404D RID: 16461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
